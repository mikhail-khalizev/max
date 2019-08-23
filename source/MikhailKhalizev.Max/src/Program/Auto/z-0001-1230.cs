using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_1230-1932de49")]
        public void Method_0001_1230()
        {
            ii(0x1_1230, 1);  push(cx);                                 /* push cx */
            ii(0x1_1231, 4);  mov(cx, memw[ds, 0xdee]);                 /* mov cx, [0xdee] */
            ii(0x1_1235, 1);  dec(cx);                                  /* dec cx */
            ii(0x1_1236, 2);  if(jnz(0x1_127b, 0x43)) goto l_0x1_127b;  /* jnz 0x127b */
            ii(0x1_1238, 3);  mov(ax, 0xde04);                          /* mov ax, 0xde04 */
        l_0x1_123b:
            ii(0x1_123b, 5);  calld_far_ind(memd[ds, 0xd5a]);           /* call far dword [0xd5a] */
            ii(0x1_1240, 1);  cli();                                    /* cli */
            ii(0x1_1241, 2);  or(ah, ah);                               /* or ah, ah */
            ii(0x1_1243, 3);  mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x1_1246, 2);  if(jnz(0x1_1279, 0x31)) goto l_0x1_1279;  /* jnz 0x1279 */
        l_0x1_1248:
            ii(0x1_1248, 3);  cmp(edi, ebx);                            /* cmp edi, ebx */
            ii(0x1_124b, 2);  if(jae(0x1_1279, 0x2c)) goto l_0x1_1279;  /* jae 0x1279 */
            ii(0x1_124d, 6);  test(memb_a32[es, edi + 0x1], 0x8);       /* test byte [es:edi+0x1], 0x8 */
            ii(0x1_1253, 2);  if(jz(0x1_125b, 0x6)) goto l_0x1_125b;    /* jz 0x125b */
            ii(0x1_1255, 4);  add(edi, 0x4);                            /* add edi, 0x4 */
            ii(0x1_1259, 2);  jmp(0x1_1248, -0x13); goto l_0x1_1248;    /* jmp 0x1248 */
        l_0x1_125b:
            ii(0x1_125b, 2);  xchg(edx, eax);                           /* xchg edx, eax */
            ii(0x1_125d, 6);  mov(edx, 0x1000);                         /* mov edx, 0x1000 */
            ii(0x1_1263, 3);  or(ax, 0x807);                            /* or ax, 0x807 */
        l_0x1_1266:
            ii(0x1_1266, 3);  stosd_a32();                              /* a32 stosd */
            ii(0x1_1269, 4);  add(eax, edx);                            /* add eax, edx */
            ii(0x1_126d, 4);  inc(memw[ds, 0xdf6]);                     /* inc word [0xdf6] */
            ii(0x1_1271, 5);  add(memd[ds, 0xaa8], edx);                /* add [0xaa8], edx */
            ii(0x1_1276, 1);  dec(cx);                                  /* dec cx */
            ii(0x1_1277, 2);  if(jns(0x1_1266, -0x13)) goto l_0x1_1266; /* jns 0x1266 */
        l_0x1_1279:
            ii(0x1_1279, 1);  pop(cx);                                  /* pop cx */
            ii(0x1_127a, 1);  retf(); return;                           /* retf */
        l_0x1_127b:
            ii(0x1_127b, 3);  mov(ax, 0xdf00);                          /* mov ax, 0xdf00 */
            ii(0x1_127e, 2);  jmp(0x1_123b, -0x45); goto l_0x1_123b;    /* jmp 0x123b */
        }
    }
}
