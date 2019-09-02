using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_3240-1932de49")]
        public void Method_0001_3240()
        {
            ii(0x1_3240, 1);  push(cx);                                 /* push cx */
            ii(0x1_3241, 4);  mov(cx, memw[ds, 0xdee]);                 /* mov cx, [0xdee] */
            ii(0x1_3245, 1);  dec(cx);                                  /* dec cx */
            ii(0x1_3246, 2);  if(jnz(0x1_328b, 0x43)) goto l_0x1_328b;  /* jnz 0x328b */
            ii(0x1_3248, 3);  mov(ax, 0xde04);                          /* mov ax, 0xde04 */
        l_0x1_324b:
            ii(0x1_324b, 5);  calld_far_ind(memd[ds, 0xd5a]);           /* call far dword [0xd5a] */
            ii(0x1_3250, 1);  cli();                                    /* cli */
            ii(0x1_3251, 2);  or(ah, ah);                               /* or ah, ah */
            ii(0x1_3253, 3);  mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x1_3256, 2);  if(jnz(0x1_3289, 0x31)) goto l_0x1_3289;  /* jnz 0x3289 */
        l_0x1_3258:
            ii(0x1_3258, 3);  cmp(edi, ebx);                            /* cmp edi, ebx */
            ii(0x1_325b, 2);  if(jae(0x1_3289, 0x2c)) goto l_0x1_3289;  /* jae 0x3289 */
            ii(0x1_325d, 6);  test(memb_a32[es, edi + 1], 8);           /* test byte [es:edi+0x1], 0x8 */
            ii(0x1_3263, 2);  if(jz(0x1_326b, 6)) goto l_0x1_326b;      /* jz 0x326b */
            ii(0x1_3265, 4);  add(edi, 4);                              /* add edi, 0x4 */
            ii(0x1_3269, 2);  jmp(0x1_3258, -0x13); goto l_0x1_3258;    /* jmp 0x3258 */
        l_0x1_326b:
            ii(0x1_326b, 2);  xchg(edx, eax);                           /* xchg edx, eax */
            ii(0x1_326d, 6);  mov(edx, 0x1000);                         /* mov edx, 0x1000 */
            ii(0x1_3273, 3);  or(ax, 0x807);                            /* or ax, 0x807 */
        l_0x1_3276:
            ii(0x1_3276, 3);  stosd_a32();                              /* a32 stosd */
            ii(0x1_3279, 4);  add(eax, edx);                            /* add eax, edx */
            ii(0x1_327d, 4);  inc(memw[ds, 0xdf6]);                     /* inc word [0xdf6] */
            ii(0x1_3281, 5);  add(memd[ds, 0xaa8], edx);                /* add [0xaa8], edx */
            ii(0x1_3286, 1);  dec(cx);                                  /* dec cx */
            ii(0x1_3287, 2);  if(jns(0x1_3276, -0x13)) goto l_0x1_3276; /* jns 0x3276 */
        l_0x1_3289:
            ii(0x1_3289, 1);  pop(cx);                                  /* pop cx */
            ii(0x1_328a, 1);  retf(); return;                           /* retf */
        l_0x1_328b:
            ii(0x1_328b, 3);  mov(ax, 0xdf00);                          /* mov ax, 0xdf00 */
            ii(0x1_328e, 2);  jmp(0x1_324b, -0x45); goto l_0x1_324b;    /* jmp 0x324b */
        }
    }
}
