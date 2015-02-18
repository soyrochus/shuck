(function()
{
 var Global=this,Runtime=this.IntelliFactory.Runtime,WebSharper,Html,Client,Default,List,Schuck,Client1,EventsPervasives,Remoting,AjaxRemotingProvider,Concurrency;
 Runtime.Define(Global,{
  Schuck:{
   Client:{
    Main:function()
    {
     var input,label,x,x1;
     input=Default.Input(List.ofArray([Default.Text("")]));
     label=Default.Div(List.ofArray([Default.Text("")]));
     x=Default.Button(List.ofArray([Default.Text("Click")]));
     x1=function()
     {
      return function()
      {
       return Client1.Start(input.get_Value(),function(out)
       {
        return label.set_Text(out);
       });
      };
     };
     EventsPervasives.Events().OnClick(x1,x);
     return Default.Div(List.ofArray([input,label,x]));
    },
    Start:function(input,k)
    {
     var f,arg00,t;
     f=function()
     {
      var x,f1;
      x=AjaxRemotingProvider.Async("Schuck:0",[input]);
      f1=function(_arg1)
      {
       var x1;
       x1=k(_arg1);
       return Concurrency.Return(x1);
      };
      return Concurrency.Bind(x,f1);
     };
     arg00=Concurrency.Delay(f);
     t={
      $:0
     };
     return Concurrency.Start(arg00,t);
    }
   },
   Controls:{
    EntryPoint:Runtime.Class({
     get_Body:function()
     {
      return Client1.Main();
     }
    })
   }
  }
 });
 Runtime.OnInit(function()
 {
  WebSharper=Runtime.Safe(Global.IntelliFactory.WebSharper);
  Html=Runtime.Safe(WebSharper.Html);
  Client=Runtime.Safe(Html.Client);
  Default=Runtime.Safe(Client.Default);
  List=Runtime.Safe(WebSharper.List);
  Schuck=Runtime.Safe(Global.Schuck);
  Client1=Runtime.Safe(Schuck.Client);
  EventsPervasives=Runtime.Safe(Client.EventsPervasives);
  Remoting=Runtime.Safe(WebSharper.Remoting);
  AjaxRemotingProvider=Runtime.Safe(Remoting.AjaxRemotingProvider);
  return Concurrency=Runtime.Safe(WebSharper.Concurrency);
 });
 Runtime.OnLoad(function()
 {
  return;
 });
}());
