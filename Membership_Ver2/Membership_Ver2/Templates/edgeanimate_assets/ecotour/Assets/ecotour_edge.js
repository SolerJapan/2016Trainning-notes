
(function($,Edge,compId){var _=null,y=true,n=false,or='-webkit-transform-origin',e19='${_underground2}',e20='${_catacombs}',b='block',e23='${_eiffel}',x13='rgba(245,224,58,1.00)',a='Base State',e27='${_underground1}',x17='hidden',x12='rgba(255,0,0,1.00)',e30='${_eiffel_title}',d='display',i='none',lf='left',e28='${_ecotour-base}',bg='background-color',x3='0.1.7',rbr='border-bottom-right-radius',x1='Arial',fs='font-size',tp='top',ov='overflow',xc='rgba(0,0,0,1)',x10='stage',c='color',x5='rgba(0,0,0,0)',g='image',e21='${_monalisa}',x15='rgba(0,136,192,1.00)',rtl='border-top-left-radius',x11='@@0@@px @@1@@px',oz='-moz-transform-origin',x7='solid',m='rect',x4='1.0.0.180',h='height',x2='1.0.0',e18='${_RoundRect}',x14='@@0@@% @@1@@%',p='px',o='opacity',e33='${_title}',e32='${_louvre_title}',oo='-o-transform-origin',rbl='border-bottom-left-radius',e31='${_champs}',e22='${_seine_title}',e29='${_Arc}',bc='border-color',ff='font-family',x6='rgba(192,192,192,0.00)',l='normal',s='style',e25='${_cruise}',e24='${_paris}',e26='${_signup}',x='text',rtr='border-top-right-radius',w='width',dt='Default Timeline',ql='linear',e16='${_Stage}',on='msTransformOrigin',x9='30',om='-ms-transform-origin',e34='${_title2}';var im='images/';var s8="SIGN UP TODAY";var fonts={};fonts[x1]='font-family=\"Arial Narrow\"';var P=Edge.P,T=Edge.T,A=Edge.A;var resources=[];var symbols={"stage":{v:x2,mv:x3,b:x4,bS:a,iS:a,gpu:y,rI:n,cn:{dom:[{id:'ecotour-base',t:g,r:['0','-339','950','808','auto','auto'],f:[x5,'eco_images/ecotour-base.png'],tf:[]},{id:'catacombs',t:g,r:['413','39','132','111','auto','auto'],f:[x5,'eco_images/catacombs.png'],tf:[]},{id:'monalisa',v:i,t:g,r:['509','67','136','102','auto','auto'],f:[x5,'eco_images/monalisa.png'],tf:[]},{id:'Arc',v:i,t:g,r:['152','34','158','105','auto','auto'],f:[x5,'eco_images/Arc.png'],tf:[]},{id:'RoundRect',t:m,r:['162','25','100','100','auto','auto'],br:["50px 50px","50px 50px","50px 50px","50px 50px"],f:[x6],s:[0,xc,x7],tf:[]},{id:'cruise',v:i,t:g,r:['2','51','165','77','auto','auto'],f:[x5,'eco_images/cruise.png'],tf:[]},{id:'eiffel',t:g,r:['187','10','88','145','auto','auto'],f:[x5,'eco_images/eiffel.png'],tf:[]},{id:'paris',t:g,r:['252','56','446','68','auto','auto'],f:[x5,'eco_images/paris.png'],tf:[]},{id:'title',t:g,r:['0','50','950','100','auto','auto'],f:[x5,'eco_images/title.png'],tf:[]},{id:'signup',v:i,t:x,r:['310','141','330','40','auto','auto'],text:s8,align:"center",n:[x1,x9,"rgba(245,224,58,1.00)",l,i,l],tf:[]},{id:'eiffel_title',t:g,r:['0','0','500','100','auto','auto'],f:[x5,'eco_images/eiffel_title.png']},{id:'underground2',t:g,r:['573','50','400','100','auto','auto'],f:[x5,'eco_images/underground2.png'],tf:[]},{id:'underground1',t:g,r:['233','55','200','100','auto','auto'],f:[x5,'eco_images/underground1.png'],tf:[]},{id:'seine_title',t:g,r:['167','49','500','75','auto','auto'],f:[x5,'eco_images/seine_title.png'],tf:[]},{id:'champs',t:g,r:['326','49','500','75','auto','auto'],f:[x5,'eco_images/champs.png'],tf:[]},{id:'louvre_title',t:g,r:['-25','80','500','75','auto','auto'],f:[x5,'eco_images/louvre_title.png'],tf:[]},{id:'title2',v:i,t:g,r:['0','37','765','100','auto','auto'],f:[x5,'eco_images/title.png'],tf:[]}],sI:[]},s:{},tl:{"Default Timeline":{fS:a,tS:"",d:63500,a:y,tt:[]}}}};var S1=symbols[x10];var tl0=S1.tl[dt].tt,st1=S1.s[a]={},A1=A(_,tl0,st1);A1.A(e16).P(bg,x15,c).P(ov,x17).P(h,200).P(w,765);A1.A(e18).P(bg,x6,c).P(rtl,[100,100],_,x11).P(rbr,[100,100],_,x11).P("border-style",x7).P(rtr,[100,100],_,x11).P(w,130).P(rbl,[100,100],_,x11).P(h,130).P(bc,x12,c).P("border-width",10).P(tp,25).T(0,25).T(23.75,12,2,ql).T(43.5,45,2).P(o,0,_,_,"").T(6.75,1,0.5).T(54,0,1).P(lf,162,_,_,p).T(14.5,423,2).T(23.75,10,2).T(33.25,168,2.6).T(43.5,481,2);A1.A(e19).P(tp,84).P(lf,46).P(o,0,_,_,"").T(17.5,1,1.75,ql).T(21.25,0,1.75);A1.A(e20).P(lf,413).P(tp,39).T(23.75,119,2,ql).P(o,0,_,_,"").T(16.5,1,1).T(25.25,0,0.5).P(d,b).T(0,i).T(16.5,b).T(25.5,i);A1.A(e21).P(d,i).T(0,i,_,_,b).T(45.5,b).P(o,0,_,_,"").T(45.5,1,1.25,ql).T(52.75,0,1.25).P(lf,509,_,_,p).T(45.5,509).P(tp,67).T(45.5,67);A1.A(e22).P(tp,49).P(lf,167).P(o,0,_,_,"").T(27,1,1.75,ql).T(30.75,0,1.75);A1.A(e23).P(d,b).T(6.25,b,_,_,i).T(16.5,i).P(o,0,_,_,"").T(7.75,1,1,ql).P(lf,187,_,_,p).T(14.5,187).P(tp,10).T(14.5,-259,2);A1.A(e24).P(lf,162).P(tp,65).T(0,65).P(o,0,_,_,"").T(0,1,1.5,ql).T(4.25,0,1.5).P(d,b).T(0,b,_,_,i).T(6.25,i);A1.A(e25).P(lf,2).P(d,i).T(0,i,_,_,b).T(25.75,b).P(o,0,_,_,"").T(25.75,1,1,ql).P(tp,51,_,_,p).T(33.25,407,2.6);A1.A(e26).P(tp,137).P("font-weight",l).P(c,x13,c).P(ff,x1).P(lf,218).P(fs,30).P(d,i).T(0,i,_,_,b).T(58.25,b).P(o,0,_,_,"").T(61.75,1,1.75,ql);A1.A(e27).P(tp,34).P(lf,238).P(o,0,_,_,"").T(17.5,1,1.75,ql).T(21.25,0,1.75);A1.A(e28).P(or,[0,50],_,x14).P(oz,[0,50],_,x14).P(om,[0,50],_,x14).P(on,[0,50],_,x14).P(oo,[0,50],_,x14).P(lf,0).P(tp,-339).T(14.5,-608,2,ql).T(23.75,-528,2).T(33.25,-172,2.6).T(43.5,-295,2).P(o,0,_,_,"").T(2.25,1,1).T(56,0,1);A1.A(e29).P(lf,152).P(d,i).T(35.85,b).P(o,0,_,_,"").T(35.85,1,1.4,ql).T(44.852,0.01,0.647).P(tp,34,_,_,p).T(43.5,-89,2);A1.A(e30).P(tp,50).P(lf,326).P(o,0,_,_,"").T(8.75,1,1.75,ql).T(12.5,0,1.75);A1.A(e31).P(tp,49).P(lf,326).P(o,0,_,_,"").T(37.25,1,1.75,ql).T(41,0,1.75);A1.A(e32).P(tp,80).P(lf,-25).P(o,0,_,_,"").T(46.75,1,1.75,ql).T(50.5,0,1.75);A1.A(e33).P(o,0,_,_,"").P(lf,-3.37,_,_,p).P(tp,47).P(d,b).T(0,i);A1.A(e34).P(tp,37).P(d,i).T(55,b).P(o,0,_,_,"").T(58.25,1,1.5,ql);Edge.registerCompositionDefn(compId,symbols,fonts,resources);$(window).ready(function(){Edge.launchComposition(compId);});})(jQuery,AdobeEdge,"EDGE-10410789");