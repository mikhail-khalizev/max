using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("60d78f3f-e21b-4968-bdd8-0a03c58b5be8")]
        public void Method_1013_3c5b()
        {
            ii(0x1013_3c5b, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1013_3c60, 5); calld(Definitions.sys_check_available_stack_size, 0x320ed); /* call 0x10165d52 */
            ii(0x1013_3c65, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_3c66, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_3c67, 1); pushd(esi);                             /* push esi */
            ii(0x1013_3c68, 1); pushd(edi);                             /* push edi */
            ii(0x1013_3c69, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_3c6a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_3c6c, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1013_3c72, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_3c75, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
        l_0x1013_3c78:
            ii(0x1013_3c78, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_3c7b, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1013_3c7e, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1013_3c81, 3); cmp(memb_a32[ds, eax], 0x20);           /* cmp byte [eax], 0x20 */
            ii(0x1013_3c84, 2); if(jnzd(0x1013_3c8e, 0x8)) goto l_0x1013_3c8e; /* jnz 0x10133c8e */
            ii(0x1013_3c86, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_3c89, 3); inc(memw_a32[ds, eax]);                 /* inc word [eax] */
            ii(0x1013_3c8c, 2); jmpd(0x1013_3c78, -0x16); goto l_0x1013_3c78; /* jmp 0x10133c78 */
        l_0x1013_3c8e:
            ii(0x1013_3c8e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_3c91, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1013_3c94, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1013_3c97, 5); calld(/* sys */ 0x1017_90ce, 0x45432);  /* call 0x101790ce */
            ii(0x1013_3c9c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1013_3c9f:
            ii(0x1013_3c9f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_3ca2, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1013_3ca5, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1013_3ca8, 3); cmp(memb_a32[ds, eax], 0x20);           /* cmp byte [eax], 0x20 */
            ii(0x1013_3cab, 2); if(jzd(0x1013_3cc1, 0x14)) goto l_0x1013_3cc1; /* jz 0x10133cc1 */
            ii(0x1013_3cad, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_3cb0, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1013_3cb3, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1013_3cb6, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1013_3cb8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_3cbd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_3cbf, 2); if(jnzd(0x1013_3cc3, 0x2)) goto l_0x1013_3cc3; /* jnz 0x10133cc3 */
        l_0x1013_3cc1:
            ii(0x1013_3cc1, 2); jmpd(0x1013_3ccb, 0x8); goto l_0x1013_3ccb; /* jmp 0x10133ccb */
        l_0x1013_3cc3:
            ii(0x1013_3cc3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_3cc6, 3); inc(memw_a32[ds, eax]);                 /* inc word [eax] */
            ii(0x1013_3cc9, 2); jmpd(0x1013_3c9f, -0x2c); goto l_0x1013_3c9f; /* jmp 0x10133c9f */
        l_0x1013_3ccb:
            ii(0x1013_3ccb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_3cce, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_3cd1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_3cd4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_3cd6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_3cd7, 1); popd(edi);                              /* pop edi */
            ii(0x1013_3cd8, 1); popd(esi);                              /* pop esi */
            ii(0x1013_3cd9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_3cda, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_3cdb, 1); retd(); return;                         /* ret */
        }
    }
}