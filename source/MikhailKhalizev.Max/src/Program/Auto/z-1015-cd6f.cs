using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_cd6f-8eed7f4a")]
        public void Method_1015_cd6f()
        {
            ii(0x1015_cd6f, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1015_cd74, 5); calld(Definitions.sys_check_available_stack_size, 0x8fd9); /* call 0x10165d52 */
            ii(0x1015_cd79, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_cd7a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_cd7b, 1); pushd(edx);                             /* push edx */
            ii(0x1015_cd7c, 1); pushd(esi);                             /* push esi */
            ii(0x1015_cd7d, 1); pushd(edi);                             /* push edi */
            ii(0x1015_cd7e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_cd7f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_cd81, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1015_cd87, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_cd8a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_cd8d, 5); calld(0x1007_611c, -0xe_6c76);          /* call 0x1007611c */
            ii(0x1015_cd92, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x1015_cd95, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_cd97, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_cd99, 5); calld(0x1007_66ac, -0xe_66f2);          /* call 0x100766ac */
            ii(0x1015_cd9e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1015_cda1, 5); calld(0x1007_6600, -0xe_67a6);          /* call 0x10076600 */
            ii(0x1015_cda6, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_cda9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_cdab, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_cdae, 3); mov(al, memb_a32[ds, edx + 0x26]);      /* mov al, [edx+0x26] */
            ii(0x1015_cdb1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_cdb4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_cdb6, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_cdb9, 3); mov(al, memb_a32[ds, edx + 0x26]);      /* mov al, [edx+0x26] */
            ii(0x1015_cdbc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_cdbf, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_cdc2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_cdc4, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1015_cdc7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_cdc9, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1015_cdce, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_cdd0, 2); if(jnzd(0x1015_cde1, 0xf)) goto l_0x1015_cde1; /* jnz 0x1015cde1 */
            ii(0x1015_cdd2, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1015_cdd7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_cdda, 5); calld(0x100f_3c32, -0x6_91ad);          /* call 0x100f3c32 */
            ii(0x1015_cddf, 2); jmpd(0x1015_ce37, 0x56); goto l_0x1015_ce37; /* jmp 0x1015ce37 */
        l_0x1015_cde1:
            ii(0x1015_cde1, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1015_cde5, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_cde7, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1015_cdec, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_cdee, 2); if(jnzd(0x1015_ce37, 0x47)) goto l_0x1015_ce37; /* jnz 0x1015ce37 */
            ii(0x1015_cdf0, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1015_cdf3, 3); mov(ebx, memd_a32[ds, ebx + 0x1a]);     /* mov ebx, [ebx+0x1a] */
            ii(0x1015_cdf6, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_cdf9, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_cdfc, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1015_cdff, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_ce02, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_ce05, 5); calld(0x1007_6aac, -0xe_635e);          /* call 0x10076aac */
            ii(0x1015_ce0a, 2); mov(ecx, memd_a32[ds, eax]);            /* mov ecx, [eax] */
            ii(0x1015_ce0c, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1015_ce0f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_ce11, 5); mov(eax, StringDefinitions.EnemyUnitCaptured); /* mov eax, 0x101b280d */
            ii(0x1015_ce16, 5); calld(0x1011_5b60, -0x4_72bb);          /* call 0x10115b60 */
            ii(0x1015_ce1b, 5); calld(0x100d_5470, -0x8_79b0);          /* call 0x100d5470 */
            ii(0x1015_ce20, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1015_ce23, 5); mov(ebx, 0x3d4);                        /* mov ebx, 0x3d4 */
            ii(0x1015_ce28, 5); mov(edx, 0x3d1);                        /* mov edx, 0x3d1 */
            ii(0x1015_ce2d, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1015_ce32, 5); calld(0x1013_daea, -0x1_f34d);          /* call 0x1013daea */
        l_0x1015_ce37:
            ii(0x1015_ce37, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_ce3a, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1015_ce3e, 2); if(jzd(0x1015_ce49, 0x9)) goto l_0x1015_ce49; /* jz 0x1015ce49 */
            ii(0x1015_ce40, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_ce43, 4); cmp(memb_a32[ds, eax + 0x3d], 0xb);     /* cmp byte [eax+0x3d], 0xb */
            ii(0x1015_ce47, 2); if(jnzd(0x1015_ce64, 0x1b)) goto l_0x1015_ce64; /* jnz 0x1015ce64 */
        l_0x1015_ce49:
            ii(0x1015_ce49, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_ce4c, 4); cmp(memb_a32[ds, eax + 0x3e], 0x19);    /* cmp byte [eax+0x3e], 0x19 */
            ii(0x1015_ce50, 2); if(jnzd(0x1015_ce5c, 0xa)) goto l_0x1015_ce5c; /* jnz 0x1015ce5c */
            ii(0x1015_ce52, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_ce55, 5); calld(0x100f_3f62, -0x6_8ef8);          /* call 0x100f3f62 */
            ii(0x1015_ce5a, 2); jmpd(0x1015_ce64, 0x8); goto l_0x1015_ce64; /* jmp 0x1015ce64 */
        l_0x1015_ce5c:
            ii(0x1015_ce5c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_ce5f, 5); calld(0x1015_0b1a, -0xc34a);            /* call 0x10150b1a */
        l_0x1015_ce64:
            ii(0x1015_ce64, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1015_ce68, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_ce6b, 5); calld(0x1015_49c5, -0x84ab);            /* call 0x101549c5 */
            ii(0x1015_ce70, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1015_ce74, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_ce77, 5); calld(0x100a_9060, -0xb_3e1c);          /* call 0x100a9060 */
            ii(0x1015_ce7c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_ce7e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1015_ce81, 5); calld(0x1007_5f2c, -0xe_6f5a);          /* call 0x10075f2c */
            ii(0x1015_ce86, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_ce88, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_ce89, 1); popd(edi);                              /* pop edi */
            ii(0x1015_ce8a, 1); popd(esi);                              /* pop esi */
            ii(0x1015_ce8b, 1); popd(edx);                              /* pop edx */
            ii(0x1015_ce8c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_ce8d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_ce8e, 1); retd(); return;                         /* ret */
        }
    }
}
