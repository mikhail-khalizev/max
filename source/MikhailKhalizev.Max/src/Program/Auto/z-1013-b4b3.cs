using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("75d8f410-cd0f-42d1-9b0b-f5d2df7d7653")]
        public void Method_1013_b4b3()
        {
            ii(0x1013_b4b3, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1013_b4b8, 5); calld(Definitions.sys_check_available_stack_size, 0x2_a895); /* call 0x10165d52 */
            ii(0x1013_b4bd, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_b4be, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_b4bf, 1); pushd(esi);                             /* push esi */
            ii(0x1013_b4c0, 1); pushd(edi);                             /* push edi */
            ii(0x1013_b4c1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_b4c2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_b4c4, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1013_b4ca, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_b4cd, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_b4d0, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1013_b4d5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1013_b4d8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b4db, 5); calld(0x1013_b3e6, -0xfa);              /* call 0x1013b3e6 */
            ii(0x1013_b4e0, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_b4e3, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_b4e7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_b4e9, 2); if(jged(0x1013_b4f4, 0x9)) goto l_0x1013_b4f4; /* jge 0x1013b4f4 */
            ii(0x1013_b4eb, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1013_b4f2, 2); jmpd(0x1013_b50d, 0x19); goto l_0x1013_b50d; /* jmp 0x1013b50d */
        l_0x1013_b4f4:
            ii(0x1013_b4f4, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_b4f8, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_b4fb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_b4fd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b500, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1013_b503, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_b505, 5); calld(0x1007_6dd0, -0xc_473a);          /* call 0x10076dd0 */
            ii(0x1013_b50a, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x1013_b50d:
            ii(0x1013_b50d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_b510, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_b512, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_b513, 1); popd(edi);                              /* pop edi */
            ii(0x1013_b514, 1); popd(esi);                              /* pop esi */
            ii(0x1013_b515, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_b516, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_b517, 1); retd(); return;                         /* ret */
        }
    }
}
