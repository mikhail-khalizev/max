using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6773fd23-e853-4c4b-af76-11cf23909847")]
        public void Method_100c_204f()
        {
            ii(0x100c_204f, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100c_2054, 5); calld(Definitions.sys_check_available_stack_size, 0xa3cf9); /* call 0x10165d52 */
            ii(0x100c_2059, 1); pushd(esi);                             /* push esi */
            ii(0x100c_205a, 1); pushd(edi);                             /* push edi */
            ii(0x100c_205b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_205c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_205e, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100c_2064, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_2067, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100c_206a, 3); mov(memb_a32[ss, ebp - 0x8], bl);       /* mov [ebp-0x8], bl */
            ii(0x100c_206d, 3); mov(memb_a32[ss, ebp - 0x4], cl);       /* mov [ebp-0x4], cl */
            ii(0x100c_2070, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100c_2074, 5); calld(0x100b_8ffa, -0x907f);            /* call 0x100b8ffa */
            ii(0x100c_2079, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x100c_207c, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100c_207e, 3); mov(cl, memb_a32[ss, ebp - 0x4]);       /* mov cl, [ebp-0x4] */
            ii(0x100c_2081, 4); movsx(ebx, memb_a32[ss, ebp - 0x8]);    /* movsx ebx, byte [ebp-0x8] */
            ii(0x100c_2085, 4); movsx(edx, memb_a32[ss, ebp - 0x14]);   /* movsx edx, byte [ebp-0x14] */
            ii(0x100c_2089, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_208c, 5); calld(0x100c_12cd, -0xdc4);             /* call 0x100c12cd */
            ii(0x100c_2091, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100c_2094, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100c_2098, 2); if(jnzd(0x100c_20a3, 0x9)) goto l_0x100c_20a3; /* jnz 0x100c20a3 */
            ii(0x100c_209a, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100c_20a1, 2); jmpd(0x100c_20d6, 0x33); goto l_0x100c_20d6; /* jmp 0x100c20d6 */
        l_0x100c_20a3:
            ii(0x100c_20a3, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100c_20a7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_20aa, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_20ad, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_20b3, 5); mov(ebx, 0x101c_a468);                  /* mov ebx, 0x101ca468 */
            ii(0x100c_20b8, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_20ba, 5); calld(0x100d_fd2c, 0x1dc6d);            /* call 0x100dfd2c */
            ii(0x100c_20bf, 3); mov(edx, memd_a32[ds, eax + 0xa]);      /* mov edx, [eax+0xa] */
            ii(0x100c_20c2, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_20c5, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100c_20c8, 5); calld(0x100b_93e1, -0x8cec);            /* call 0x100b93e1 */
            ii(0x100c_20cd, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100c_20d0, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x100c_20d3, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x100c_20d6:
            ii(0x100c_20d6, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100c_20d9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_20db, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_20dc, 1); popd(edi);                              /* pop edi */
            ii(0x100c_20dd, 1); popd(esi);                              /* pop esi */
            ii(0x100c_20de, 1); retd(); return;                         /* ret */
        }
    }
}