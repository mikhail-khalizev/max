using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("13611f43-8501-4185-9a69-0eda9e07c3c9")]
        public void Method_1011_e8d9()
        {
            ii(0x1011_e8d9, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1011_e8de, 5); calld(Definitions.sys_check_available_stack_size, 0x4_746f); /* call 0x10165d52 */
            ii(0x1011_e8e3, 1); pushd(esi);                             /* push esi */
            ii(0x1011_e8e4, 1); pushd(edi);                             /* push edi */
            ii(0x1011_e8e5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_e8e6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_e8e8, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1011_e8ee, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_e8f1, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1011_e8f4, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1011_e8f7, 3); mov(memb_a32[ss, ebp - 0x4], cl);       /* mov [ebp-0x4], cl */
            ii(0x1011_e8fa, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_e8fc, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_e8ff, 3); mov(al, memb_a32[ds, edx + 0x26]);      /* mov al, [edx+0x26] */
            ii(0x1011_e902, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_e905, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_e908, 5); calld(0x1007_6338, -0xa_85d5);          /* call 0x10076338 */
            ii(0x1011_e90d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_e90f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1011_e912, 5); calld(0x1007_64b8, -0xa_845f);          /* call 0x100764b8 */
            ii(0x1011_e917, 2); jmpd(0x1011_e921, 0x8); goto l_0x1011_e921; /* jmp 0x1011e921 */
        l_0x1011_e919:
            ii(0x1011_e919, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1011_e91c, 5); calld(0x1007_6bf8, -0xa_7d29);          /* call 0x10076bf8 */
        l_0x1011_e921:
            ii(0x1011_e921, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e923, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1011_e926, 5); calld(0x1013_ad71, 0x1_c446);           /* call 0x1013ad71 */
            ii(0x1011_e92b, 2); test(al, al);                           /* test al, al */
            ii(0x1011_e92d, 6); if(jzd(0x1011_ea27, 0xf4)) goto l_0x1011_ea27; /* jz 0x1011ea27 */
            ii(0x1011_e933, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1011_e936, 5); calld(0x1007_63a0, -0xa_859b);          /* call 0x100763a0 */
            ii(0x1011_e93b, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1011_e93f, 2); if(jzd(0x1011_e956, 0x15)) goto l_0x1011_e956; /* jz 0x1011e956 */
            ii(0x1011_e941, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1011_e945, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1011_e948, 5); calld(0x1007_63a0, -0xa_85ad);          /* call 0x100763a0 */
            ii(0x1011_e94d, 5); calld(0x1007_6074, -0xa_88de);          /* call 0x10076074 */
            ii(0x1011_e952, 2); test(al, al);                           /* test al, al */
            ii(0x1011_e954, 2); if(jnzd(0x1011_e95b, 0x5)) goto l_0x1011_e95b; /* jnz 0x1011e95b */
        l_0x1011_e956:
            ii(0x1011_e956, 5); jmpd(0x1011_ea22, 0xc7); goto l_0x1011_ea22; /* jmp 0x1011ea22 */
        l_0x1011_e95b:
            ii(0x1011_e95b, 4); test(memb_a32[ss, ebp - 0x4], 0x2);     /* test byte [ebp-0x4], 0x2 */
            ii(0x1011_e95f, 2); if(jnzd(0x1011_e981, 0x20)) goto l_0x1011_e981; /* jnz 0x1011e981 */
            ii(0x1011_e961, 4); test(memb_a32[ss, ebp - 0x4], 0x1);     /* test byte [ebp-0x4], 0x1 */
            ii(0x1011_e965, 2); if(jzd(0x1011_e97c, 0x15)) goto l_0x1011_e97c; /* jz 0x1011e97c */
            ii(0x1011_e967, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1011_e96a, 5); calld(0x1007_63a0, -0xa_85cf);          /* call 0x100763a0 */
            ii(0x1011_e96f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e971, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1011_e974, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1011_e978, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_e97a, 2); if(jnzd(0x1011_e981, 0x5)) goto l_0x1011_e981; /* jnz 0x1011e981 */
        l_0x1011_e97c:
            ii(0x1011_e97c, 5); jmpd(0x1011_ea22, 0xa1); goto l_0x1011_ea22; /* jmp 0x1011ea22 */
        l_0x1011_e981:
            ii(0x1011_e981, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1011_e984, 5); calld(0x1007_63a0, -0xa_85e9);          /* call 0x100763a0 */
            ii(0x1011_e989, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1011_e98c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_e98f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_e992, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1011_e995, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_e997, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1011_e99a, 5); calld(0x1007_63a0, -0xa_85ff);          /* call 0x100763a0 */
            ii(0x1011_e99f, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x1011_e9a2, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_e9a5, 2); mov(eax, memd_a32[ds, edx]);            /* mov eax, [edx] */
            ii(0x1011_e9a7, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1011_e9a9, 3); mov(memb_a32[ds, eax], 0);              /* mov byte [eax], 0x0 */
            ii(0x1011_e9ac, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e9ae, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1011_e9b1, 5); calld(0x1007_63a0, -0xa_8616);          /* call 0x100763a0 */
            ii(0x1011_e9b6, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1011_e9b9, 5); calld(0x1013_ad71, 0x1_c3b3);           /* call 0x1013ad71 */
            ii(0x1011_e9be, 2); test(al, al);                           /* test al, al */
            ii(0x1011_e9c0, 2); if(jzd(0x1011_e9d0, 0xe)) goto l_0x1011_e9d0; /* jz 0x1011e9d0 */
            ii(0x1011_e9c2, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1011_e9c5, 5); calld(0x1007_63a0, -0xa_862a);          /* call 0x100763a0 */
            ii(0x1011_e9ca, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1);     /* cmp byte [eax+0x3e], 0x1 */
            ii(0x1011_e9ce, 2); if(jnzd(0x1011_e9d2, 0x2)) goto l_0x1011_e9d2; /* jnz 0x1011e9d2 */
        l_0x1011_e9d0:
            ii(0x1011_e9d0, 2); jmpd(0x1011_e9df, 0xd); goto l_0x1011_e9df; /* jmp 0x1011e9df */
        l_0x1011_e9d2:
            ii(0x1011_e9d2, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1011_e9d5, 5); calld(0x1007_6408, -0xa_85d2);          /* call 0x10076408 */
            ii(0x1011_e9da, 3); cmp(eax, memd_a32[ss, ebp - 0x8]);      /* cmp eax, [ebp-0x8] */
            ii(0x1011_e9dd, 2); if(jnzd(0x1011_e9e1, 0x2)) goto l_0x1011_e9e1; /* jnz 0x1011e9e1 */
        l_0x1011_e9df:
            ii(0x1011_e9df, 2); jmpd(0x1011_ea22, 0x41); goto l_0x1011_ea22; /* jmp 0x1011ea22 */
        l_0x1011_e9e1:
            ii(0x1011_e9e1, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1011_e9e4, 5); calld(0x1007_63a0, -0xa_8649);          /* call 0x100763a0 */
            ii(0x1011_e9e9, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1011_e9ec, 5); calld(0x1007_69d8, -0xa_8019);          /* call 0x100769d8 */
            ii(0x1011_e9f1, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1011_e9f4, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1011_e9f7, 3); mov(ecx, memd_a32[ds, eax + 0x2]);      /* mov ecx, [eax+0x2] */
            ii(0x1011_e9fa, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1011_e9fd, 5); calld(0x1007_63d4, -0xa_862e);          /* call 0x100763d4 */
            ii(0x1011_ea02, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1011_ea04, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1011_ea07, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1011_ea0a, 3); calld_abs(memd_a32[ds, ecx + 0x18]);    /* call dword [ecx+0x18] */
            ii(0x1011_ea0d, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1011_ea11, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_ea14, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1011_ea17, 4); movsx(edx, memw_a32[ss, ebp - 0x1e]);   /* movsx edx, word [ebp-0x1e] */
            ii(0x1011_ea1b, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_ea1d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_ea1f, 3); mov(memb_a32[ds, eax], 0);              /* mov byte [eax], 0x0 */
        l_0x1011_ea22:
            ii(0x1011_ea22, 5); jmpd(0x1011_e919, -0x10e); goto l_0x1011_e919; /* jmp 0x1011e919 */
        l_0x1011_ea27:
            ii(0x1011_ea27, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_ea29, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1011_ea2c, 5); calld(0x1007_5f6c, -0xa_8ac5);          /* call 0x10075f6c */
            ii(0x1011_ea31, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_ea33, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_ea34, 1); popd(edi);                              /* pop edi */
            ii(0x1011_ea35, 1); popd(esi);                              /* pop esi */
            ii(0x1011_ea36, 1); retd(); return;                         /* ret */
        }
    }
}
