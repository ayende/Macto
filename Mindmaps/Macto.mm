<map version="0.9.0" NAME="Macto" DATE="1310319686000" FILE="Macto.mm" MAPID="4817028" BGCOLOR="#F2F3F7">
<node ID="ID_7427528864" TEXT="Macto" COLOR="#000034" STYLE="NodeMasterGraphic">
<font NAME="SansSerif" SIZE="16" />
<edge COLOR="#309EFF" />
<richcontent TYPE="NOTE">
<pre>Incarceration management system</pre>
</richcontent>
<node ID="ID_8858684885" TEXT="Accepting inmates" POSITION="right" COLOR="#000034" STYLE="NodeBasicGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_1475305082" TEXT="Placement" COLOR="#000034" STYLE="NodeBasicGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_4164312515" TEXT="Always happens when inmate is accepted, since it leads to responsibility assignment" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_1126242763" TEXT="Even if inmate goes to the hospital" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_7466117424" TEXT="If he is not assigned to anyone, he is not counted" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
</node>
<node ID="ID_8247701047" TEXT="Choice" COLOR="#000034" STYLE="NodeBasicGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_3676356060" TEXT="Just arrested, sentenced, sentenced for a long time..." COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_3124718083" TEXT="Reason for incarceration" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_3165744001" TEXT="Attitudes: fights, suicidal, ..." COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_6831220548" TEXT="Room availability" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
</node>
<node ID="ID_6045838211" TEXT="Phisical location" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_4637855073" TEXT="Inmate can be lent for good reasons" COLOR="#000034" STYLE="NodeTextGraphic" SELECTED="true">
<edge COLOR="#309EFF" />
</node>
</node>
</node>
<node ID="ID_8682501204" TEXT="Different workflows according to inmate source" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_4535407475" TEXT="System cannot deny people" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_4042528585" TEXT="Requires identification of inmate" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_7322086041" TEXT="Requires CLAI" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_4023151308" TEXT="Leads to creation or activation of the dossier" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
<arrowlink ARROW_ID="ID_2470431053" COLOR="#309EFF" DESTINATION="ID_8078580726" STARTINCLINATION="-230;12;" ENDINCLINATION="-197;14;" STARTARROW="None" ENDARROW="Default" />
</node>
<node ID="ID_6374544274" TEXT="Ends with the inmate arriving in his bunk" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_7046223107" TEXT="Leads to" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_5666476783" TEXT="addition of inmate to prison's roster" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_3460058161" TEXT="Responsibility for inmate" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
<arrowlink ARROW_ID="ID_1142238702" DESTINATION="ID_8677303238" STARTINCLINATION="-123;72;" ENDINCLINATION="56;-82;" STARTARROW="None" ENDARROW="Default" />
<arrowlink ARROW_ID="ID_7210418200" DESTINATION="ID_5181438812" STARTINCLINATION="99;1;" ENDINCLINATION="265;-3;" STARTARROW="None" ENDARROW="Default" />
</node>
</node>
</node>
<node ID="ID_6836388075" TEXT="In Lawful Custody" POSITION="right" COLOR="#000034" STYLE="NodeBasicGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_8677303238" TEXT="Signed on" COLOR="#000034" STYLE="NodeBasicGraphic">
<edge COLOR="#309EFF" />
<arrowlink ARROW_ID="ID_2504653207" COLOR="#309EFF" DESTINATION="ID_1475305082" STARTINCLINATION="286;9;" ENDINCLINATION="226;120;" STARTARROW="None" ENDARROW="Default" />
<node ID="ID_6131852448" TEXT="Who has legal responsibility" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
</node>
<node ID="ID_5181438812" TEXT="Overall responsibility" COLOR="#000034" STYLE="NodeBasicGraphic">
<edge COLOR="#309EFF" />
<richcontent TYPE="NOTE">
<pre>Even if inmate is away, this guy is responsible, for example, to track his status in his report</pre>
</richcontent>
<arrowlink ARROW_ID="ID_2704784801" DESTINATION="ID_1475305082" STARTINCLINATION="443;7;" ENDINCLINATION="194;95;" STARTARROW="None" ENDARROW="Default" />
</node>
<node ID="ID_3545216072" TEXT="Ordered By" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_0280151838" TEXT="Police officer with usually 24 hour limit" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_6836155714" TEXT="Judge" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
</node>
<node ID="ID_5422144527" TEXT="Means" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_4467784730" TEXT="Fed" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_7435501871" TEXT="Reasonable conditions" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_3273182357" TEXT="Communicate with lawyers and family" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_2061166806" TEXT="Access to medical facilities" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
</node>
</node>
<node ID="ID_8078580726" TEXT="Dossier" POSITION="left" COLOR="#000034" STYLE="NodeBasicGraphic">
<edge COLOR="#309EFF" />
<richcontent TYPE="NOTE">
<pre>Legal stuff</pre>
</richcontent>
<arrowlink ARROW_ID="ID_1654053733" COLOR="#34ADFD" DESTINATION="ID_0451681858" STARTINCLINATION="-89;43;" ENDINCLINATION="-29;-104;" STARTARROW="None" ENDARROW="Default" />
<node ID="ID_3866272015" TEXT="Chain of lawful authority for incarceration" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
<richcontent TYPE="NOTE">
<pre>Unlawful incarceration is a bad thing!
History of events the inmate has gone through</pre>
</richcontent>
<node ID="ID_5682613874" TEXT="Warrants" COLOR="#000034" STYLE="NodeBasicGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_5381572337" TEXT="Meta Types" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_5762676681" TEXT="Hourly warrant" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_1275118486" TEXT="Important to match the hours " COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_3325103304" TEXT="hourly Warrants requires that by the time the Warrant expire, you are either got a new one at court or let the Inmate go." COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
</node>
<node ID="ID_2145141321" TEXT="Days, months, ..." COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_2018440111" TEXT="Usually inmate is released in the morning" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
</node>
</node>
<node ID="ID_6403800122" TEXT="Unlawfully withholding freedom when not respected" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_3236725061" TEXT="Have a duration" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_6408682012" TEXT="Can be renewed by court" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_0315345747" TEXT="Never exceed duration except for special cases" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_3158307632" TEXT="Types" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_5605067716" TEXT="Arrest Warrant &#8211; Issued by an officer, generally hold for 24 hours only" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_6654378275" TEXT="can only be given by Officers of rank Captain and above" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
</node>
<node ID="ID_0227520774" TEXT="Detention Warrant &#8211; Issued by the court, generally for a short amount of time, up to a few weeks, in most cases" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_5185182813" TEXT="Remand Warrant &#8211; Issued by the court, generally instructing the prison to hold the Inmate in custody until sentencing (not limited in time)." COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_5641757731" TEXT="Sentencing Warrant &#8211; Issued by the court, specifying the total time that an Inmate is to be incarcerated." COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_4037751153" TEXT="Mandamus warrant (whateverthe judge said)" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
</node>
<node ID="ID_3326576570" TEXT="Have an issuer" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_3057634074" TEXT="Last one is the valid one" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_3860228124" TEXT="Should be continuous, gaps are bad" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
</node>
</node>
<node ID="ID_5604186721" TEXT="Contains Incarcerations" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_0300442840" TEXT="Can overlap" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
</node>
<node ID="ID_4688463738" TEXT="Quo warranto enquiries" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_6335228440" TEXT="Inmate location" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_7385770831" TEXT="Report" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_4408154010" TEXT="Aggressive, suicidal..." COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
</node>
<node ID="ID_6321543123" TEXT="Can be archived" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
<arrowlink ARROW_ID="ID_5118687836" COLOR="#309EFF" DESTINATION="ID_2205061417" STARTINCLINATION="240;1;" ENDINCLINATION="337;-12;" STARTARROW="Default" ENDARROW="None" />
<arrowlink ARROW_ID="ID_5122463237" COLOR="#309EFF" DESTINATION="ID_1140281445" STARTINCLINATION="234;-4;" ENDINCLINATION="381;2;" STARTARROW="Default" ENDARROW="None" />
</node>
<node ID="ID_3881726838" TEXT="Can be reactivated" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_6275625746" TEXT="If not found, a new one can be created" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
</node>
<node ID="ID_4415007882" TEXT="Can be flagged if it needs special attention" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
</node>
<node ID="ID_2503588184" TEXT="Action Plan" POSITION="right" COLOR="#000034" STYLE="NodeBasicGraphic">
<edge COLOR="#309EFF" />
<richcontent TYPE="NOTE">
<pre>Which Inmates go home today? Which Inmates&#8217; incarceration should be extended? Which of the Inmates need to go to court? Notify interested parties about Inmates who are scheduled to be released soon. Are there any Inmates who should have been freed but are still hanging around?</pre>
</richcontent>
</node>
<node ID="ID_0451681858" TEXT="Inmate" POSITION="left" COLOR="#000034" STYLE="NodeBasicGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_1621702124" TEXT="Is not created, rather accepted" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_1140281445" TEXT="Released when warrant runs out" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_2205061417" TEXT="Can be transfered out" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_0673077606" TEXT="Might escape!" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
<arrowlink ARROW_ID="ID_8803833765" DESTINATION="ID_1362813554" STARTINCLINATION="-211;-5;" ENDINCLINATION="0;-150;" STARTARROW="None" ENDARROW="Default" />
</node>
</node>
<node ID="ID_1362813554" TEXT="Counting" POSITION="left" COLOR="#000034" STYLE="NodeBasicGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_8767383785" TEXT="Actually just accounted for, except at opening and closing" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_5332180535" TEXT="Types" COLOR="#000034" STYLE="NodeBasicGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_8641520144" TEXT="Opening count" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_2472353854" TEXT="Noon counting" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_1035883145" TEXT="Closing count" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
</node>
<node ID="ID_2165162511" TEXT="Unlikely discrepancies between opening and closing" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_0674748188" TEXT="Records" COLOR="#000034" STYLE="NodeBasicGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_3077837146" TEXT="How many inmates were present" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_1060701367" TEXT="How many were supposed Tibet there" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_3352380610" TEXT="If there are discrepancies, are they accounted for?" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
</node>
</node>
<node ID="ID_7078402562" TEXT="Record" POSITION="right" COLOR="#000034" STYLE="NodeBasicGraphic">
<edge COLOR="#309EFF" />
<richcontent TYPE="NOTE">
<pre>Stuff prison staff needs to know about inmate</pre>
</richcontent>
<node ID="ID_2266061004" TEXT="Cliff notes" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_1210143523" TEXT="This guys may do bad things" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_3848442576" TEXT="Don't leave him alone" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_8756300458" TEXT="..." COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
</node>
<node ID="ID_0111373873" TEXT="Full report" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_2246314222" TEXT="Used in" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_4655848388" TEXT="Intelligence reviews" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_3506503067" TEXT="Interviews" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_7607338122" TEXT="Parole hearings" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
</node>
<node ID="ID_0787060656" TEXT="Contains" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
<node ID="ID_3351881285" TEXT="Guard's reports" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_6616720124" TEXT="Intelligence gathered" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
<node ID="ID_8681821137" TEXT="Disciplinary measures" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
</node>
</node>
<node ID="ID_1177237653" TEXT="For Staff" COLOR="#000034" STYLE="NodeTextGraphic">
<edge COLOR="#309EFF" />
</node>
</node>
</node>
</map>
