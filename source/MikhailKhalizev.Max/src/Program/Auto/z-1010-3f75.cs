using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1da9cc30-f128-4ddb-93a2-a6582230d211")]
        public void Method_1010_3f75()
        {
            ii(0x1010_3f75, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1010_3f7a, 5); calld(Definitions.sys_check_available_stack_size, 0x61dd3); /* call 0x10165d52 */
            ii(0x1010_3f7f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_3f80, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_3f81, 1); pushd(esi);                             /* push esi */
            ii(0x1010_3f82, 1); pushd(edi);                             /* push edi */
            ii(0x1010_3f83, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_3f84, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_3f86, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_3f8c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_3f8f, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_3f92, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1010_3f96, 2); if(jnzd(0x1010_3fb1, 0x19)) goto l_0x1010_3fb1; /* jnz 0x10103fb1 */
            ii(0x1010_3f98, 5); mov(ecx, 0x1a9);                        /* mov ecx, 0x1a9 */
            ii(0x1010_3f9d, 5); mov(ebx, StringDefinitions.HashCpp);    /* mov ebx, 0x101a326f */
            ii(0x1010_3fa2, 5); mov(edx, StringDefinitions.AttemptedToRemoveNullUnitFromUnitHashTable); /* mov edx, 0x101a3278 */
            ii(0x1010_3fa7, 5); mov(eax, StringDefinitions.Unit0);      /* mov eax, 0x101a32ac */
            ii(0x1010_3fac, 5); calld(0x100f_07d4, -0x137dd);           /* call 0x100f07d4 */
        l_0x1010_3fb1:
            ii(0x1010_3fb1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_3fb4, 5); calld(0x1007_6154, -0x8de65);           /* call 0x10076154 */
            ii(0x1010_3fb9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_3fbb, 3); mov(dx, ax);                            /* mov dx, ax */
            ii(0x1010_3fbe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_3fc1, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x1010_3fc4, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_3fc6, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_3fc9, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_3fcb, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1010_3fce, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_3fd1, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x1010_3fd5, 3); imul(ebx, ebx, 0xa);                    /* imul ebx, ebx, 0xa */
            ii(0x1010_3fd8, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_3fdb, 3); mov(edx, memd_a32[ds, edx + 0x2]);      /* mov edx, [edx+0x2] */
            ii(0x1010_3fde, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x1010_3fe0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_3fe2, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1010_3fe4, 5); calld(0x1008_aab4, -0x79535);           /* call 0x1008aab4 */
            ii(0x1010_3fe9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_3feb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_3fec, 1); popd(edi);                              /* pop edi */
            ii(0x1010_3fed, 1); popd(esi);                              /* pop esi */
            ii(0x1010_3fee, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_3fef, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_3ff0, 1); retd(); return;                         /* ret */
        }
    }
}
