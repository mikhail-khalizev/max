using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_8f09-3d0bdb19")]
        public void Method_1015_8f09()
        {
            ii(0x1015_8f09, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_8f0e, 5); calld(Definitions.sys_check_available_stack_size, 0xce3f); /* call 0x10165d52 */
            ii(0x1015_8f13, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_8f14, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_8f15, 1); pushd(esi);                             /* push esi */
            ii(0x1015_8f16, 1); pushd(edi);                             /* push edi */
            ii(0x1015_8f17, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_8f18, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_8f1a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_8f20, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_8f23, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_8f26, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_8f29, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_8f2c, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_8f31, 5); calld(0x100f_448c, -0x6_4aaa);          /* call 0x100f448c */
            ii(0x1015_8f36, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_8f39, 4); cmp(memb_a32[ds, eax + 0x57], 0x6);     /* cmp byte [eax+0x57], 0x6 */
            ii(0x1015_8f3d, 2); if(jnzd(0x1015_8f48, 0x9)) goto l_0x1015_8f48; /* jnz 0x10158f48 */
            ii(0x1015_8f3f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_8f42, 4); mov(memb_a32[ds, eax + 0x57], 0);       /* mov byte [eax+0x57], 0x0 */
            ii(0x1015_8f46, 2); jmpd(0x1015_8f4f, 0x7); goto l_0x1015_8f4f; /* jmp 0x10158f4f */
        l_0x1015_8f48:
            ii(0x1015_8f48, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_8f4b, 4); mov(memb_a32[ds, eax + 0x57], 0x6);     /* mov byte [eax+0x57], 0x6 */
        l_0x1015_8f4f:
            ii(0x1015_8f4f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_8f51, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_8f52, 1); popd(edi);                              /* pop edi */
            ii(0x1015_8f53, 1); popd(esi);                              /* pop esi */
            ii(0x1015_8f54, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_8f55, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_8f56, 1); retd();                                 /* ret */
        }
    }
}
