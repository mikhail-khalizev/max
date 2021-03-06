using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_b239-f399fe60")]
        public void Method_1010_b239()
        {
            ii(0x1010_b239, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1010_b23e, 5);  call(Definitions.sys_check_available_stack_size, 0x5_ab0f);/* call 0x10165d52 */
            ii(0x1010_b243, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_b244, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_b245, 1);  push(edx);                            /* push edx */
            ii(0x1010_b246, 1);  push(esi);                            /* push esi */
            ii(0x1010_b247, 1);  push(edi);                            /* push edi */
            ii(0x1010_b248, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_b249, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_b24b, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1010_b251, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_b254, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b257, 3);  mov(eax, memd[ds, eax + 13]);         /* mov eax, [eax+0xd] */
            ii(0x1010_b25a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_b25d, 5);  jmp(0x1010_b2e4, 0x82); goto l_0x1010_b2e4;/* jmp 0x1010b2e4 */
        l_0x1010_b262:
            ii(0x1010_b262, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1010_b269, 7);  mov(memd[ss, ebp - 12], 0x64);        /* mov dword [ebp-0xc], 0x64 */
            ii(0x1010_b270, 5);  jmp(0x1010_b300, 0x8b); goto l_0x1010_b300;/* jmp 0x1010b300 */
        l_0x1010_b275:
            ii(0x1010_b275, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1010_b27c, 7);  mov(memd[ss, ebp - 12], 0xc8);        /* mov dword [ebp-0xc], 0xc8 */
            ii(0x1010_b283, 5);  jmp(0x1010_b300, 0x78); goto l_0x1010_b300;/* jmp 0x1010b300 */
        l_0x1010_b288:
            ii(0x1010_b288, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1010_b28f, 7);  mov(memd[ss, ebp - 12], 0x190);       /* mov dword [ebp-0xc], 0x190 */
            ii(0x1010_b296, 2);  jmp(0x1010_b300, 0x68); goto l_0x1010_b300;/* jmp 0x1010b300 */
        l_0x1010_b298:
            ii(0x1010_b298, 7);  mov(memd[ss, ebp - 16], 1);           /* mov dword [ebp-0x10], 0x1 */
            ii(0x1010_b29f, 7);  mov(memd[ss, ebp - 12], 0xc8);        /* mov dword [ebp-0xc], 0xc8 */
            ii(0x1010_b2a6, 2);  jmp(0x1010_b300, 0x58); goto l_0x1010_b300;/* jmp 0x1010b300 */
        l_0x1010_b2a8:
            ii(0x1010_b2a8, 7);  mov(memd[ss, ebp - 16], 1);           /* mov dword [ebp-0x10], 0x1 */
            ii(0x1010_b2af, 7);  mov(memd[ss, ebp - 12], 0x190);       /* mov dword [ebp-0xc], 0x190 */
            ii(0x1010_b2b6, 2);  jmp(0x1010_b300, 0x48); goto l_0x1010_b300;/* jmp 0x1010b300 */
        l_0x1010_b2b8:
            ii(0x1010_b2b8, 7);  mov(memd[ss, ebp - 16], 1);           /* mov dword [ebp-0x10], 0x1 */
            ii(0x1010_b2bf, 7);  mov(memd[ss, ebp - 12], 0x320);       /* mov dword [ebp-0xc], 0x320 */
            ii(0x1010_b2c6, 2);  jmp(0x1010_b300, 0x38); goto l_0x1010_b300;/* jmp 0x1010b300 */
        l_0x1010_b2c8:
            ii(0x1010_b2c8, 2);  jmp(0x1010_b300, 0x36); goto l_0x1010_b300;/* jmp 0x1010b300 */
        //  ii(0x1010_b2ca, 26);  Недостижимый код.
        l_0x1010_b2e4:
            ii(0x1010_b2e4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_b2e7, 3);  sub(eax, 0x28);                       /* sub eax, 0x28 */
            ii(0x1010_b2ea, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1010_b2ed, 4);  cmp(memd[ss, ebp - 20], 5);           /* cmp dword [ebp-0x14], 0x5 */
            ii(0x1010_b2f1, 2);  if(ja(0x1010_b2c8, -0x2b)) goto l_0x1010_b2c8;/* ja 0x1010b2c8 */
            ii(0x1010_b2f3, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1010_b2f6, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_b2f9, 7);  /* jmp dword [cs:eax+0x1010b2cc] */
            switch (jmp_abs_switch(memd[cs, eax + 0x1010_b2cc]))
            {
                case 0x1010_b262:
                    goto l_0x1010_b262;
                case 0x1010_b275:
                    goto l_0x1010_b275;
                case 0x1010_b288:
                    goto l_0x1010_b288;
                case 0x1010_b298:
                    goto l_0x1010_b298;
                case 0x1010_b2a8:
                    goto l_0x1010_b2a8;
                case 0x1010_b2b8:
                    goto l_0x1010_b2b8;
                default:
                    throw new NotImplementedException();
            }
        l_0x1010_b300:
            ii(0x1010_b300, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1010_b303, 5);  mov(eax, 0x4a);                       /* mov eax, 0x4a */
            ii(0x1010_b308, 5);  call(0x100c_aafc, -0x4_0811);         /* call 0x100caafc */
            ii(0x1010_b30d, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1010_b310, 5);  mov(eax, 0x4b);                       /* mov eax, 0x4b */
            ii(0x1010_b315, 5);  call(0x100c_aafc, -0x4_081e);         /* call 0x100caafc */
            ii(0x1010_b31a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b31d, 5);  call(0x1010_a69d, -0xc85);            /* call 0x1010a69d */
            ii(0x1010_b322, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b325, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_b327, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1010_b32a, 5);  call(Definitions.sys_display_draw_0, 0x5_c155);/* call 0x10167484 */
            ii(0x1010_b32f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_b331, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_b332, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_b333, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_b334, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_b335, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_b336, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_b337, 1);  ret();                                /* ret */
        }
    }
}
