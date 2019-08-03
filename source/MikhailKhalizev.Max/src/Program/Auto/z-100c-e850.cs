using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("90396393-b869-49d1-a494-162f30c736ed")]
        public void Method_100c_e850()
        {
            ii(0x100c_e850, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_e855, 5); calld(Definitions.sys_check_available_stack_size, 0x974f8); /* call 0x10165d52 */
            ii(0x100c_e85a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_e85b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_e85c, 1); pushd(edx);                             /* push edx */
            ii(0x100c_e85d, 1); pushd(esi);                             /* push esi */
            ii(0x100c_e85e, 1); pushd(edi);                             /* push edi */
            ii(0x100c_e85f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_e860, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_e862, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_e868, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_e86b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e86e, 4); cmp(memd_a32[ds, eax + 0x10], 0);       /* cmp dword [eax+0x10], 0x0 */
            ii(0x100c_e872, 2); if(jnzd(0x100c_e87d, 0x9)) goto l_0x100c_e87d; /* jnz 0x100ce87d */
            ii(0x100c_e874, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x100c_e87b, 2); jmpd(0x100c_e88b, 0xe); goto l_0x100c_e88b; /* jmp 0x100ce88b */
        l_0x100c_e87d:
            ii(0x100c_e87d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_e880, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x100c_e883, 5); calld(0x100d_4e8c, 0x6604);             /* call 0x100d4e8c */
            ii(0x100c_e888, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x100c_e88b:
            ii(0x100c_e88b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_e88e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_e890, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_e891, 1); popd(edi);                              /* pop edi */
            ii(0x100c_e892, 1); popd(esi);                              /* pop esi */
            ii(0x100c_e893, 1); popd(edx);                              /* pop edx */
            ii(0x100c_e894, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_e895, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_e896, 1); retd(); return;                         /* ret */
        }
    }
}
