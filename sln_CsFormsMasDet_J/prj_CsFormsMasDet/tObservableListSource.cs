using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;              // IList
using System.Collections.ObjectModel;  // ObservableCollection<>
using System.ComponentModel;           // IBindingList, IListSource
using System.Data.Entity;              // ToBindingList()


namespace prj_CsFormsMasDet
{
  // adds IListSource functionality to builtin ObservableCollection<>
  // IListSource allows databinding to winform controls
  public class tObservableListSource<T> : ObservableCollection<T>, IListSource where T : class
  {
    // fields

    private IBindingList m_oIBindingList = null;


    // properties

    bool IListSource.ContainsListCollection
    {
      get
      {
        // return true to indicate it contains a collection of collections (like a dataset)
        // return false to indicate it contains a collection of objs       (like a table)
        return false;
      }
    }
    
    
    // methods
    
    // returns IBindingList that stays in sync with ObservableCollection
    IList IListSource.GetList()
    {
      // ToBindingList() (extension defined in EF assembly) produces an IBindingList that supports sorting
      return this.m_oIBindingList ?? ( this.m_oIBindingList = this.ToBindingList() );
    }

  } // class

} // ns
