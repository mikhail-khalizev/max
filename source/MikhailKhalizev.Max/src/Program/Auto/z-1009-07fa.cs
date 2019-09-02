using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_07fa-880cad82")]
        public void Method_1009_07fa()
        {
            ii(0x1009_07fa, 5); push(0x48);                             /* push 0x48 */
            ii(0x1009_07ff, 5); call(Definitions.sys_check_available_stack_size, 0xd_554e); /* call 0x10165d52 */
            ii(0x1009_0804, 1); push(ebx);                              /* push ebx */
            ii(0x1009_0805, 1); push(ecx);                              /* push ecx */
            ii(0x1009_0806, 1); push(esi);                              /* push esi */
            ii(0x1009_0807, 1); push(edi);                              /* push edi */
            ii(0x1009_0808, 1); push(ebp);                              /* push ebp */
            ii(0x1009_0809, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_080b, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1009_0811, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_0814, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1009_0817, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_0819, 1); push(eax);                              /* push eax */
            ii(0x1009_081a, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x1009_081f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_0822, 1); push(eax);                              /* push eax */
            ii(0x1009_0823, 6); mov(ecx, memd[ds, 0x101c_8170]);        /* mov ecx, [0x101c8170] */
            ii(0x1009_0829, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1009_082c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_082e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_0830, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1009_0833, 5); call(0x1008_b148, -0x56f0);             /* call 0x1008b148 */
            ii(0x1009_0838, 3); push(memd[ds, eax + 12]);               /* push dword [eax+0xc] */
            ii(0x1009_083b, 3); push(memd[ds, eax + 8]);                /* push dword [eax+0x8] */
            ii(0x1009_083e, 3); push(memd[ds, eax + 4]);                /* push dword [eax+0x4] */
            ii(0x1009_0841, 2); push(memd[ds, eax]);                    /* push dword [eax] */
            ii(0x1009_0843, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_0846, 5); call(0x1009_02f8, -0x553);              /* call 0x100902f8 */
            ii(0x1009_084b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_084e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_0851, 7); mov(memd[ds, eax + 35], 0x101b_4658);   /* mov dword [eax+0x23], 0x101b4658 */
            ii(0x1009_0858, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_085b, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1009_085e, 3); mov(memd[ds, edx + 39], eax);           /* mov [edx+0x27], eax */
            ii(0x1009_0861, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_0864, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1009_0867, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1009_086a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_086c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_086d, 1); pop(edi);                               /* pop edi */
            ii(0x1009_086e, 1); pop(esi);                               /* pop esi */
            ii(0x1009_086f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_0870, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_0871, 1); ret();                                  /* ret */
        }
    }
}
