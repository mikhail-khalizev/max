using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_bf07-1b906bca")]
        public void Method_100d_bf07()
        {
            ii(0x100d_bf07, 5); push(0x20);                             /* push 0x20 */
            ii(0x100d_bf0c, 5); call(Definitions.sys_check_available_stack_size, 0x8_9e41); /* call 0x10165d52 */
            ii(0x100d_bf11, 1); push(ebx);                              /* push ebx */
            ii(0x100d_bf12, 1); push(ecx);                              /* push ecx */
            ii(0x100d_bf13, 1); push(edx);                              /* push edx */
            ii(0x100d_bf14, 1); push(esi);                              /* push esi */
            ii(0x100d_bf15, 1); push(edi);                              /* push edi */
            ii(0x100d_bf16, 1); push(ebp);                              /* push ebp */
            ii(0x100d_bf17, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_bf19, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100d_bf1f, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100d_bf22, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_bf25, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100d_bf28, 5); call(Definitions.my_2_get_count, -0x5_0bc5); /* call 0x1008b368 */
            ii(0x100d_bf2d, 1); cwde();                                 /* cwde */
            ii(0x100d_bf2e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_bf30, 2); if(jz(0x100d_bf4e, 0x1c)) goto l_0x100d_bf4e; /* jz 0x100dbf4e */
            ii(0x100d_bf32, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_bf35, 3); mov(edx, memd[ds, eax + 36]);           /* mov edx, [eax+0x24] */
            ii(0x100d_bf38, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_bf3b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_bf3e, 3); add(eax, 0x48);                         /* add eax, 0x48 */
            ii(0x100d_bf41, 5); call(0x100e_0934, 0x49ee);              /* call 0x100e0934 */
            ii(0x100d_bf46, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_bf49, 5); call(0x100d_0749, -0xb805);             /* call 0x100d0749 */
        l_0x100d_bf4e:
            ii(0x100d_bf4e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_bf50, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_bf51, 1); pop(edi);                               /* pop edi */
            ii(0x100d_bf52, 1); pop(esi);                               /* pop esi */
            ii(0x100d_bf53, 1); pop(edx);                               /* pop edx */
            ii(0x100d_bf54, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_bf55, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_bf56, 1); ret();                                  /* ret */
        }
    }
}
