using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_07ed-41a13af3")]
        public void Method_1007_07ed()
        {
            ii(0x1007_07ed, 5); pushd(0x4c);                            /* push 0x4c */
            ii(0x1007_07f2, 5); calld(Definitions.sys_check_available_stack_size, 0xf_555b); /* call 0x10165d52 */
            ii(0x1007_07f7, 1); pushd(esi);                             /* push esi */
            ii(0x1007_07f8, 1); pushd(edi);                             /* push edi */
            ii(0x1007_07f9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_07fa, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_07fc, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x1007_0802, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_0805, 3); mov(memd_a32[ss, ebp - 0x10], edx);     /* mov [ebp-0x10], edx */
            ii(0x1007_0808, 3); mov(memd_a32[ss, ebp - 0xc], ebx);      /* mov [ebp-0xc], ebx */
            ii(0x1007_080b, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x1007_080e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_0810, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1007_0813, 3); mov(al, memb_a32[ds, edx + 0x26]);      /* mov al, [edx+0x26] */
            ii(0x1007_0816, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1007_0819, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_081c, 5); calld(0x1007_623c, 0x5a1b);             /* call 0x1007623c */
            ii(0x1007_0821, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1007_0824, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x1007_0827, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1007_082a, 2); if(jmpd_func(0x1007_0880, 0x54)) return; /* jmp 0x10070880 */
            ii(0x1007_082c, 7); mov(memd_a32[ss, ebp - 0x18], 0x1);     /* mov dword [ebp-0x18], 0x1 */
            ii(0x1007_0833, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
            ii(0x1007_083a, 2); if(jmpd_func(0x1007_089d, 0x61)) return; /* jmp 0x1007089d */
            ii(0x1007_083c, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1007_0843, 7); mov(memd_a32[ss, ebp - 0x20], 0x1);     /* mov dword [ebp-0x20], 0x1 */
            ii(0x1007_084a, 2); if(jmpd_func(0x1007_089d, 0x51)) return; /* jmp 0x1007089d */
            ii(0x1007_084c, 7); mov(memd_a32[ss, ebp - 0x18], 0xffff_ffff); /* mov dword [ebp-0x18], 0xffffffff */
            ii(0x1007_0853, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
            ii(0x1007_085a, 2); if(jmpd_func(0x1007_089d, 0x41)) return; /* jmp 0x1007089d */
            ii(0x1007_085c, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1007_0863, 7); mov(memd_a32[ss, ebp - 0x20], 0xffff_ffff); /* mov dword [ebp-0x20], 0xffffffff */
            ii(0x1007_086a, 2); if(jmpd_func(0x1007_089d, 0x31)) return; /* jmp 0x1007089d */
        }
    }
}
