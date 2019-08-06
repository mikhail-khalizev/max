using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ea758214-4cf0-469e-81f7-271ac3a39cfc")]
        public void Method_1012_4e9c()
        {
            ii(0x1012_4e9c, 5); pushd(0x58);                            /* push 0x58 */
            ii(0x1012_4ea1, 5); calld(Definitions.sys_check_available_stack_size, 0x40eac); /* call 0x10165d52 */
            ii(0x1012_4ea6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_4ea7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_4ea8, 1); pushd(edx);                             /* push edx */
            ii(0x1012_4ea9, 1); pushd(esi);                             /* push esi */
            ii(0x1012_4eaa, 1); pushd(edi);                             /* push edi */
            ii(0x1012_4eab, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_4eac, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_4eae, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x1012_4eb4, 5); calld(0x1012_4e17, -0xa2);              /* call 0x10124e17 */
            ii(0x1012_4eb9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_4ebb, 2); if(jnzd(0x1012_4ec6, 0x9)) goto l_0x1012_4ec6; /* jnz 0x10124ec6 */
            ii(0x1012_4ebd, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1012_4ec4, 2); jmpd(0x1012_4f22, 0x5c); goto l_0x1012_4f22; /* jmp 0x10124f22 */
        l_0x1012_4ec6:
            ii(0x1012_4ec6, 5); mov(ecx, 0x31);                         /* mov ecx, 0x31 */
            ii(0x1012_4ecb, 3); lea(ebx, ebp - 0x3c);                   /* lea ebx, [ebp-0x3c] */
            ii(0x1012_4ece, 5); mov(edx, 0x5f);                         /* mov edx, 0x5f */
            ii(0x1012_4ed3, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1012_4ed8, 5); calld(0x1010_6281, -0x1ec5c);           /* call 0x10106281 */
            ii(0x1012_4edd, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1012_4ee0, 5); calld(Definitions.sys_strlen, 0x4cfe2); /* call 0x10171ec7 */
            ii(0x1012_4ee5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_4ee8, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x1012_4eec, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x1012_4ef1, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1012_4ef3, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1012_4ef5, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1012_4ef9, 3); lea(ebx, ebp - 0x3c);                   /* lea ebx, [ebp-0x3c] */
            ii(0x1012_4efc, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1012_4efe, 5); mov(edx, 0x61);                         /* mov edx, 0x61 */
            ii(0x1012_4f03, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1012_4f08, 5); calld(0x1010_6281, -0x1ec8c);           /* call 0x10106281 */
            ii(0x1012_4f0d, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1012_4f10, 5); calld(0x1012_4d8a, -0x18b);             /* call 0x10124d8a */
            ii(0x1012_4f15, 5); mov(eax, StringDefinitions.Connect2);   /* mov eax, 0x101a818e */
            ii(0x1012_4f1a, 5); calld(0x1012_4c13, -0x30c);             /* call 0x10124c13 */
            ii(0x1012_4f1f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1012_4f22:
            ii(0x1012_4f22, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_4f25, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_4f27, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_4f28, 1); popd(edi);                              /* pop edi */
            ii(0x1012_4f29, 1); popd(esi);                              /* pop esi */
            ii(0x1012_4f2a, 1); popd(edx);                              /* pop edx */
            ii(0x1012_4f2b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_4f2c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_4f2d, 1); retd(); return;                         /* ret */
        }
    }
}
