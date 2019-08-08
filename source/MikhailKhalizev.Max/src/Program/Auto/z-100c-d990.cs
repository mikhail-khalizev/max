using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4e1541c2-cf2f-40ff-8418-866d1ed19b90")]
        public void Method_100c_d990()
        {
            ii(0x100c_d990, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_d995, 5); calld(Definitions.sys_check_available_stack_size, 0x9_83b8); /* call 0x10165d52 */
            ii(0x100c_d99a, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_d99b, 1); pushd(esi);                             /* push esi */
            ii(0x100c_d99c, 1); pushd(edi);                             /* push edi */
            ii(0x100c_d99d, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_d99e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_d9a0, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100c_d9a6, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_d9a9, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100c_d9ac, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100c_d9af, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_d9b2, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_d9b5, 4); cmp(ax, memw_a32[ds, edx + 0x2]);       /* cmp ax, [edx+0x2] */
            ii(0x100c_d9b9, 2); if(jled(0x100c_d9c5, 0xa)) goto l_0x100c_d9c5; /* jle 0x100cd9c5 */
            ii(0x100c_d9bb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_d9be, 4); mov(ax, memw_a32[ds, eax + 0x2]);       /* mov ax, [eax+0x2] */
            ii(0x100c_d9c2, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
        l_0x100c_d9c5:
            ii(0x100c_d9c5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_d9c8, 4); mov(dx, memw_a32[ds, eax + 0x2]);       /* mov dx, [eax+0x2] */
            ii(0x100c_d9cc, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_d9cf, 4); cmp(dx, memw_a32[ds, eax + 0x4]);       /* cmp dx, [eax+0x4] */
            ii(0x100c_d9d3, 2); if(jged(0x100c_da2d, 0x58)) goto l_0x100c_da2d; /* jge 0x100cda2d */
            ii(0x100c_d9d5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_d9d8, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_d9db, 4); cmp(ax, memw_a32[ds, edx + 0x2]);       /* cmp ax, [edx+0x2] */
            ii(0x100c_d9df, 2); if(jged(0x100c_da28, 0x47)) goto l_0x100c_da28; /* jge 0x100cda28 */
            ii(0x100c_d9e1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_d9e4, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100c_d9e6, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_d9e9, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_d9ed, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100c_d9ef, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_d9f2, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x100c_d9f5, 3); imul(ebx, edx);                         /* imul ebx, edx */
            ii(0x100c_d9f8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_d9fb, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100c_d9fe, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_da02, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_da05, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_da08, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100c_da0b, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_da0d, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x100c_da11, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_da14, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_da17, 1); inc(ecx);                               /* inc ecx */
            ii(0x100c_da18, 3); imul(ecx, eax);                         /* imul ecx, eax */
            ii(0x100c_da1b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_da1e, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100c_da21, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x100c_da23, 5); calld(/* sys */ 0x1016_6177, 0x9_874f); /* call 0x10166177 */
        l_0x100c_da28:
            ii(0x100c_da28, 5); jmpd(0x100c_dae3, 0xb6); goto l_0x100c_dae3; /* jmp 0x100cdae3 */
        l_0x100c_da2d:
            ii(0x100c_da2d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_da30, 4); mov(dx, memw_a32[ds, eax + 0x6]);       /* mov dx, [eax+0x6] */
            ii(0x100c_da34, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_da37, 4); add(memw_a32[ds, eax + 0x4], dx);       /* add [eax+0x4], dx */
            ii(0x100c_da3b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_da3e, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100c_da41, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_da44, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_da47, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_da4a, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100c_da4d, 5); calld(Definitions.sys_new_arr, 0x9_85be); /* call 0x10166010 */
            ii(0x100c_da52, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_da55, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_da59, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_da5b, 2); if(jled(0x100c_da78, 0x1b)) goto l_0x100c_da78; /* jle 0x100cda78 */
            ii(0x100c_da5d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_da60, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x100c_da63, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_da67, 3); imul(ebx, eax);                         /* imul ebx, eax */
            ii(0x100c_da6a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_da6d, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x100c_da70, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_da73, 5); calld(Definitions.sys_memcpy, 0x9_83d3); /* call 0x10165e4b */
        l_0x100c_da78:
            ii(0x100c_da78, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_da7b, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_da7e, 4); cmp(ax, memw_a32[ds, edx + 0x2]);       /* cmp ax, [edx+0x2] */
            ii(0x100c_da82, 2); if(jged(0x100c_dac6, 0x42)) goto l_0x100c_dac6; /* jge 0x100cdac6 */
            ii(0x100c_da84, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_da87, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100c_da89, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_da8c, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_da90, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100c_da92, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_da95, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x100c_da98, 3); imul(ebx, edx);                         /* imul ebx, edx */
            ii(0x100c_da9b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_da9e, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100c_daa1, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_daa5, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_daa8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_daab, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100c_daae, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_dab0, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x100c_dab4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_dab7, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_daba, 1); inc(ecx);                               /* inc ecx */
            ii(0x100c_dabb, 3); imul(eax, ecx);                         /* imul eax, ecx */
            ii(0x100c_dabe, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x100c_dac1, 5); calld(Definitions.sys_memcpy, 0x9_8385); /* call 0x10165e4b */
        l_0x100c_dac6:
            ii(0x100c_dac6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_dac9, 4); cmp(memd_a32[ds, eax + 0x8], 0);        /* cmp dword [eax+0x8], 0x0 */
            ii(0x100c_dacd, 2); if(jzd(0x100c_dada, 0xb)) goto l_0x100c_dada; /* jz 0x100cdada */
            ii(0x100c_dacf, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_dad2, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100c_dad5, 5); calld(Definitions.sys_delete, 0x9_848a); /* call 0x10165f64 */
        l_0x100c_dada:
            ii(0x100c_dada, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_dadd, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_dae0, 3); mov(memd_a32[ds, edx + 0x8], eax);      /* mov [edx+0x8], eax */
        l_0x100c_dae3:
            ii(0x100c_dae3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_dae6, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x100c_dae9, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_daec, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_daef, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x100c_daf2, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_daf6, 3); imul(ecx, eax);                         /* imul ecx, eax */
            ii(0x100c_daf9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_dafc, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100c_daff, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x100c_db01, 5); calld(Definitions.sys_memcpy, 0x9_8345); /* call 0x10165e4b */
            ii(0x100c_db06, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_db09, 4); inc(memw_a32[ds, eax + 0x2]);           /* inc word [eax+0x2] */
            ii(0x100c_db0d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_db0f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_db10, 1); popd(edi);                              /* pop edi */
            ii(0x100c_db11, 1); popd(esi);                              /* pop esi */
            ii(0x100c_db12, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_db13, 1); retd(); return;                         /* ret */
        }
    }
}
