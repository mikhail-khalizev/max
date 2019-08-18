using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_12b5-e43d9044")]
        public void Method_1011_12b5()
        {
            ii(0x1011_12b5, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1011_12ba, 5); calld(Definitions.sys_check_available_stack_size, 0x5_4a93); /* call 0x10165d52 */
            ii(0x1011_12bf, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_12c0, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_12c1, 1); pushd(edx);                             /* push edx */
            ii(0x1011_12c2, 1); pushd(esi);                             /* push esi */
            ii(0x1011_12c3, 1); pushd(edi);                             /* push edi */
            ii(0x1011_12c4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_12c5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_12c7, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1011_12cd, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_12d0, 7); mov(memd_a32[ss, ebp - 0x8], 0x13);     /* mov dword [ebp-0x8], 0x13 */
        l_0x1011_12d7:
            ii(0x1011_12d7, 3); dec(memd_a32[ss, ebp - 0x8]);           /* dec dword [ebp-0x8] */
            ii(0x1011_12da, 5); cmp(memw_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x1011_12df, 2); if(jzd(0x1011_1324, 0x43)) goto l_0x1011_1324; /* jz 0x10111324 */
            ii(0x1011_12e1, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_12e5, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_12e8, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_12eb, 4); cmp(memd_a32[ds, eax + 0x10], 0);       /* cmp dword [eax+0x10], 0x0 */
            ii(0x1011_12ef, 2); if(jzd(0x1011_1322, 0x31)) goto l_0x1011_1322; /* jz 0x10111322 */
            ii(0x1011_12f1, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_12f5, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_12f8, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_12fb, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x1011_12fe, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_1301, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1011_1305, 2); if(jzd(0x1011_131b, 0x14)) goto l_0x1011_131b; /* jz 0x1011131b */
            ii(0x1011_1307, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_1309, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_130c, 5); calld(Definitions.my_dtor_d2, -0x4_2dd9); /* call 0x100ce538 */
            ii(0x1011_1311, 5); calld(Definitions.sys_delete, 0x5_4c4e); /* call 0x10165f64 */
            ii(0x1011_1316, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_1319, 2); jmpd(0x1011_1322, 0x7); goto l_0x1011_1322; /* jmp 0x10111322 */
        l_0x1011_131b:
            ii(0x1011_131b, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x1011_1322:
            ii(0x1011_1322, 2); jmpd(0x1011_12d7, -0x4d); goto l_0x1011_12d7; /* jmp 0x101112d7 */
        l_0x1011_1324:
            ii(0x1011_1324, 7); mov(memd_a32[ss, ebp - 0x8], 0xc);      /* mov dword [ebp-0x8], 0xc */
        l_0x1011_132b:
            ii(0x1011_132b, 3); dec(memd_a32[ss, ebp - 0x8]);           /* dec dword [ebp-0x8] */
            ii(0x1011_132e, 5); cmp(memw_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x1011_1333, 2); if(jzd(0x1011_1359, 0x24)) goto l_0x1011_1359; /* jz 0x10111359 */
            ii(0x1011_1335, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_1339, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_133c, 7); cmp(memd_a32[ds, eax + 0x101c_4df4], 0); /* cmp dword [eax+0x101c4df4], 0x0 */
            ii(0x1011_1343, 2); if(jzd(0x1011_1357, 0x12)) goto l_0x1011_1357; /* jz 0x10111357 */
            ii(0x1011_1345, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_1349, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_134c, 6); mov(eax, memd_a32[ds, eax + 0x101c_4df4]); /* mov eax, [eax+0x101c4df4] */
            ii(0x1011_1352, 5); calld(Definitions.sys_delete, 0x5_4c0d); /* call 0x10165f64 */
        l_0x1011_1357:
            ii(0x1011_1357, 2); jmpd(0x1011_132b, -0x2e); goto l_0x1011_132b; /* jmp 0x1011132b */
        l_0x1011_1359:
            ii(0x1011_1359, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_135c, 7); cmp(memd_a32[ds, eax + 0x144], 0);      /* cmp dword [eax+0x144], 0x0 */
            ii(0x1011_1363, 2); if(jzd(0x1011_137d, 0x18)) goto l_0x1011_137d; /* jz 0x1011137d */
            ii(0x1011_1365, 5); mov(edx, 0x101b_5c10);                  /* mov edx, 0x101b5c10 */
            ii(0x1011_136a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_136d, 6); mov(eax, memd_a32[ds, eax + 0x144]);    /* mov eax, [eax+0x144] */
            ii(0x1011_1373, 5); calld(Definitions.sys_call_dtor_arr, 0x5_4c40); /* call 0x10165fb8 */
            ii(0x1011_1378, 5); calld(Definitions.sys_delete_arr, 0x5_4c5b); /* call 0x10165fd8 */
        l_0x1011_137d:
            ii(0x1011_137d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_137f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_1380, 1); popd(edi);                              /* pop edi */
            ii(0x1011_1381, 1); popd(esi);                              /* pop esi */
            ii(0x1011_1382, 1); popd(edx);                              /* pop edx */
            ii(0x1011_1383, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_1384, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_1385, 1); retd(); return;                         /* ret */
        }
    }
}
