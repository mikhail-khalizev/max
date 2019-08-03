using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d9bde855-2990-4a4b-b333-6b6f41cf0e0b")]
        public void Method_1007_6e7c()
        {
            ii(0x1007_6e7c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_6e81, 5); calld(Definitions.sys_check_available_stack_size, 0xeeecc); /* call 0x10165d52 */
            ii(0x1007_6e86, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_6e87, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_6e88, 1); pushd(esi);                             /* push esi */
            ii(0x1007_6e89, 1); pushd(edi);                             /* push edi */
            ii(0x1007_6e8a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_6e8b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6e8d, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_6e93, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_6e96, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_6e99, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6e9c, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1007_6e9f, 2); if(jled(0x1007_6ea9, 0x8)) goto l_0x1007_6ea9; /* jle 0x10076ea9 */
            ii(0x1007_6ea1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6ea4, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_6ea7, 2); jmpd(0x1007_6eaf, 0x6); goto l_0x1007_6eaf; /* jmp 0x10076eaf */
        l_0x1007_6ea9:
            ii(0x1007_6ea9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_6eac, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1007_6eaf:
            ii(0x1007_6eaf, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_6eb2, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_6eb5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_6eb8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6eba, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_6ebb, 1); popd(edi);                              /* pop edi */
            ii(0x1007_6ebc, 1); popd(esi);                              /* pop esi */
            ii(0x1007_6ebd, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_6ebe, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_6ebf, 1); retd(); return;                         /* ret */
        }
    }
}
