using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3128756b-8cd3-4288-828c-a30ee94845cd")]
        public void Method_1015_80ae()
        {
            ii(0x1015_80ae, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_80b3, 5); calld(Definitions.sys_check_available_stack_size, 0xdc9a); /* call 0x10165d52 */
            ii(0x1015_80b8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_80b9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_80ba, 1); pushd(esi);                             /* push esi */
            ii(0x1015_80bb, 1); pushd(edi);                             /* push edi */
            ii(0x1015_80bc, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_80bd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_80bf, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_80c5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_80c8, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_80cb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_80ce, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_80d1, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_80d6, 5); calld(0x100f_448c, -0x6_3c4f);          /* call 0x100f448c */
            ii(0x1015_80db, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1015_80de, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_80e1, 5); calld(0x1008_a998, -0xc_d74e);          /* call 0x1008a998 */
            ii(0x1015_80e6, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_80e8, 5); mov(edx, 0x1c);                         /* mov edx, 0x1c */
            ii(0x1015_80ed, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_80f0, 5); calld(0x1016_3053, 0xaf5e);             /* call 0x10163053 */
            ii(0x1015_80f5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_80f7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_80f8, 1); popd(edi);                              /* pop edi */
            ii(0x1015_80f9, 1); popd(esi);                              /* pop esi */
            ii(0x1015_80fa, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_80fb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_80fc, 1); retd(); return;                         /* ret */
        }
    }
}
