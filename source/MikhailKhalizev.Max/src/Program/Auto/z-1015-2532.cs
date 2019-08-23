using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_2532-85022004")]
        public void Method_1015_2532()
        {
            ii(0x1015_2532, 5); push(0x20);                             /* push 0x20 */
            ii(0x1015_2537, 5); call(Definitions.sys_check_available_stack_size, 0x1_3816); /* call 0x10165d52 */
            ii(0x1015_253c, 1); push(ebx);                              /* push ebx */
            ii(0x1015_253d, 1); push(ecx);                              /* push ecx */
            ii(0x1015_253e, 1); push(esi);                              /* push esi */
            ii(0x1015_253f, 1); push(edi);                              /* push edi */
            ii(0x1015_2540, 1); push(ebp);                              /* push ebp */
            ii(0x1015_2541, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_2543, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_2549, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_254c, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_254f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_2552, 3); mov(edx, memd[ds, eax + 0x14]);         /* mov edx, [eax+0x14] */
            ii(0x1015_2555, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_2558, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_255b, 3); sar(edx, 0x6);                          /* sar edx, 0x6 */
            ii(0x1015_255e, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1015_2560, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_2563, 3); mov(edx, memd[ds, eax + 0x16]);         /* mov edx, [eax+0x16] */
            ii(0x1015_2566, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_2569, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_256c, 3); sar(edx, 0x6);                          /* sar edx, 0x6 */
            ii(0x1015_256f, 3); mov(memd[ds, eax + 0x4], edx);          /* mov [eax+0x4], edx */
            ii(0x1015_2572, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_2575, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1015_2577, 1); inc(eax);                               /* inc eax */
            ii(0x1015_2578, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_257b, 3); mov(memd[ds, edx + 0x8], eax);          /* mov [edx+0x8], eax */
            ii(0x1015_257e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_2581, 3); mov(eax, memd[ds, eax + 0x4]);          /* mov eax, [eax+0x4] */
            ii(0x1015_2584, 1); inc(eax);                               /* inc eax */
            ii(0x1015_2585, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_2588, 3); mov(memd[ds, edx + 0xc], eax);          /* mov [edx+0xc], eax */
            ii(0x1015_258b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_258e, 4); test(memb[ds, eax + 0x12], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x1015_2592, 2); if(jz(0x1015_25a0, 0xc)) goto l_0x1015_25a0; /* jz 0x101525a0 */
            ii(0x1015_2594, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_2597, 3); inc(memd[ds, eax + 0x8]);               /* inc dword [eax+0x8] */
            ii(0x1015_259a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_259d, 3); inc(memd[ds, eax + 0xc]);               /* inc dword [eax+0xc] */
        l_0x1015_25a0:
            ii(0x1015_25a0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_25a2, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_25a3, 1); pop(edi);                               /* pop edi */
            ii(0x1015_25a4, 1); pop(esi);                               /* pop esi */
            ii(0x1015_25a5, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_25a6, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_25a7, 1); ret();                                  /* ret */
        }
    }
}
