using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6e00-7983c751")]
        public void Method_1007_6e00()
        {
            ii(0x1007_6e00, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_6e05, 5); calld(Definitions.sys_check_available_stack_size, 0xe_ef48); /* call 0x10165d52 */
            ii(0x1007_6e0a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_6e0b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_6e0c, 1); pushd(esi);                             /* push esi */
            ii(0x1007_6e0d, 1); pushd(edi);                             /* push edi */
            ii(0x1007_6e0e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_6e0f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6e11, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_6e17, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_6e1a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_6e1d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6e20, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1007_6e22, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1007_6e25, 2); if(jnzd(0x1007_6e2d, 0x6)) goto l_0x1007_6e2d; /* jnz 0x10076e2d */
            ii(0x1007_6e27, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1007_6e2b, 2); jmpd(0x1007_6e31, 0x4); goto l_0x1007_6e31; /* jmp 0x10076e31 */
        l_0x1007_6e2d:
            ii(0x1007_6e2d, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1007_6e31:
            ii(0x1007_6e31, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1007_6e34, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1007_6e37, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1007_6e3a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6e3c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_6e3d, 1); popd(edi);                              /* pop edi */
            ii(0x1007_6e3e, 1); popd(esi);                              /* pop esi */
            ii(0x1007_6e3f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_6e40, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_6e41, 1); retd();                                 /* ret */
        }
    }
}
