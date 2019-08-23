using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_f25d-d7b47439")]
        public void Method_100d_f25d()
        {
            ii(0x100d_f25d, 5); push(0x30);                             /* push 0x30 */
            ii(0x100d_f262, 5); call(Definitions.sys_check_available_stack_size, 0x8_6aeb); /* call 0x10165d52 */
            ii(0x100d_f267, 1); push(ebx);                              /* push ebx */
            ii(0x100d_f268, 1); push(ecx);                              /* push ecx */
            ii(0x100d_f269, 1); push(edx);                              /* push edx */
            ii(0x100d_f26a, 1); push(esi);                              /* push esi */
            ii(0x100d_f26b, 1); push(edi);                              /* push edi */
            ii(0x100d_f26c, 1); push(ebp);                              /* push ebp */
            ii(0x100d_f26d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_f26f, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100d_f275, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_f278, 5); mov(ebx, 0x101b_38d0);                  /* mov ebx, 0x101b38d0 */
            ii(0x100d_f27d, 5); mov(edx, 0x5d);                         /* mov edx, 0x5d */
            ii(0x100d_f282, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_f285, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x100d_f288, 5); call(Definitions.sys_call_ctor_arr_v2, 0x8_6ce3); /* call 0x10165f70 */
            ii(0x100d_f28d, 3); sub(eax, 0x8);                          /* sub eax, 0x8 */
            ii(0x100d_f290, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_f293, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100d_f296, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_f299, 5); mov(ebx, 0x101b_38d0);                  /* mov ebx, 0x101b38d0 */
            ii(0x100d_f29e, 5); mov(edx, 0x5d);                         /* mov edx, 0x5d */
            ii(0x100d_f2a3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_f2a6, 5); add(eax, 0x17c);                        /* add eax, 0x17c */
            ii(0x100d_f2ab, 5); call(Definitions.sys_call_ctor_arr_v2, 0x8_6cc0); /* call 0x10165f70 */
            ii(0x100d_f2b0, 5); sub(eax, 0x17c);                        /* sub eax, 0x17c */
            ii(0x100d_f2b5, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_f2b8, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100d_f2bb, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100d_f2be, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_f2c1, 5); add(eax, 0x2f0);                        /* add eax, 0x2f0 */
            ii(0x100d_f2c6, 5); call(0x100e_0d24, 0x1a59);              /* call 0x100e0d24 */
            ii(0x100d_f2cb, 5); sub(eax, 0x2f0);                        /* sub eax, 0x2f0 */
            ii(0x100d_f2d0, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_f2d3, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100d_f2d6, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_f2d9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_f2dc, 6); mov(memw[ds, eax + 0x6], 0);            /* mov word [eax+0x6], 0x0 */
            ii(0x100d_f2e2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_f2e5, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_f2e8, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_f2eb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_f2ed, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_f2ee, 1); pop(edi);                               /* pop edi */
            ii(0x100d_f2ef, 1); pop(esi);                               /* pop esi */
            ii(0x100d_f2f0, 1); pop(edx);                               /* pop edx */
            ii(0x100d_f2f1, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_f2f2, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_f2f3, 1); ret();                                  /* ret */
        }
    }
}
