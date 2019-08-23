using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_0e54-322a8471")]
        public void Method_1009_0e54()
        {
            ii(0x1009_0e54, 5); pushd(0x4c);                            /* push 0x4c */
            ii(0x1009_0e59, 5); calld(Definitions.sys_check_available_stack_size, 0xd_4ef4); /* call 0x10165d52 */
            ii(0x1009_0e5e, 1); pushd(esi);                             /* push esi */
            ii(0x1009_0e5f, 1); pushd(edi);                             /* push edi */
            ii(0x1009_0e60, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_0e61, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_0e63, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x1009_0e69, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_0e6c, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1009_0e6f, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1009_0e72, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1009_0e75, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_0e78, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_0e7b, 5); calld(0x1007_6338, -0x1_ab48);          /* call 0x10076338 */
            ii(0x1009_0e80, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x1009_0e83, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_0e85, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_0e87, 5); calld(0x1007_64b8, -0x1_a9d4);          /* call 0x100764b8 */
            ii(0x1009_0e8c, 2); jmpd(0x1009_0e96, 0x8); goto l_0x1009_0e96; /* jmp 0x10090e96 */
        l_0x1009_0e8e:
            ii(0x1009_0e8e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_0e91, 5); calld(0x1007_6bf8, -0x1_a29e);          /* call 0x10076bf8 */
        l_0x1009_0e96:
            ii(0x1009_0e96, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_0e98, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_0e9b, 5); calld(0x1013_ad71, 0xa_9ed1);           /* call 0x1013ad71 */
            ii(0x1009_0ea0, 2); test(al, al);                           /* test al, al */
            ii(0x1009_0ea2, 6); if(jzd(0x1009_0fb9, 0x111)) goto l_0x1009_0fb9; /* jz 0x10090fb9 */
            ii(0x1009_0ea8, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_0eab, 5); calld(0x1007_63a0, -0x1_ab10);          /* call 0x100763a0 */
            ii(0x1009_0eb0, 5); cmp(memw_a32[ds, eax + 0x8], 0x21);     /* cmp word [eax+0x8], 0x21 */
            ii(0x1009_0eb5, 2); if(jzd(0x1009_0ec6, 0xf)) goto l_0x1009_0ec6; /* jz 0x10090ec6 */
            ii(0x1009_0eb7, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_0eba, 5); calld(0x1007_63a0, -0x1_ab1f);          /* call 0x100763a0 */
            ii(0x1009_0ebf, 5); cmp(memw_a32[ds, eax + 0x8], 0x27);     /* cmp word [eax+0x8], 0x27 */
            ii(0x1009_0ec4, 2); if(jnzd(0x1009_0ecb, 0x5)) goto l_0x1009_0ecb; /* jnz 0x10090ecb */
        l_0x1009_0ec6:
            ii(0x1009_0ec6, 5); jmpd(0x1009_0fb4, 0xe9); goto l_0x1009_0fb4; /* jmp 0x10090fb4 */
        l_0x1009_0ecb:
            ii(0x1009_0ecb, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1009_0ece, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_0ed1, 5); calld(0x1007_63a0, -0x1_ab36);          /* call 0x100763a0 */
            ii(0x1009_0ed6, 5); calld(0x1015_2532, 0xc_1657);           /* call 0x10152532 */
            ii(0x1009_0edb, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1009_0edf, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x1009_0ee3, 5); calld(0x1007_3cfd, -0x1_d1eb);          /* call 0x10073cfd */
            ii(0x1009_0ee8, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1009_0eed, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1009_0ef0, 2); if(jnzd(0x1009_0f56, 0x64)) goto l_0x1009_0f56; /* jnz 0x10090f56 */
            ii(0x1009_0ef2, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1009_0ef7, 1); pushd(eax);                             /* push eax */
            ii(0x1009_0ef8, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1009_0efc, 1); pushd(eax);                             /* push eax */
            ii(0x1009_0efd, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_0f00, 5); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1009_0f05, 1); cwde();                                 /* cwde */
            ii(0x1009_0f06, 1); pushd(eax);                             /* push eax */
            ii(0x1009_0f07, 4); movsx(ecx, memw_a32[ss, ebp - 0x20]);   /* movsx ecx, word [ebp-0x20] */
            ii(0x1009_0f0b, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_0f0e, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x1009_0f11, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x1009_0f14, 1); inc(eax);                               /* inc eax */
            ii(0x1009_0f15, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_0f18, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_0f1b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_0f1e, 5); calld(0x1009_0aaa, -0x479);             /* call 0x10090aaa */
            ii(0x1009_0f23, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1009_0f28, 1); pushd(eax);                             /* push eax */
            ii(0x1009_0f29, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_0f2c, 5); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1009_0f31, 1); cwde();                                 /* cwde */
            ii(0x1009_0f32, 1); pushd(eax);                             /* push eax */
            ii(0x1009_0f33, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1009_0f37, 1); pushd(eax);                             /* push eax */
            ii(0x1009_0f38, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_0f3b, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x1009_0f3e, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x1009_0f41, 1); inc(eax);                               /* inc eax */
            ii(0x1009_0f42, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1009_0f45, 4); movsx(ebx, memw_a32[ss, ebp - 0x24]);   /* movsx ebx, word [ebp-0x24] */
            ii(0x1009_0f49, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_0f4c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_0f4f, 5); calld(0x1009_0aaa, -0x4aa);             /* call 0x10090aaa */
            ii(0x1009_0f54, 2); jmpd(0x1009_0fb4, 0x5e); goto l_0x1009_0fb4; /* jmp 0x10090fb4 */
        l_0x1009_0f56:
            ii(0x1009_0f56, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1009_0f5b, 1); pushd(eax);                             /* push eax */
            ii(0x1009_0f5c, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1009_0f60, 1); pushd(eax);                             /* push eax */
            ii(0x1009_0f61, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_0f64, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1009_0f67, 1); cwde();                                 /* cwde */
            ii(0x1009_0f68, 1); pushd(eax);                             /* push eax */
            ii(0x1009_0f69, 4); movsx(ecx, memw_a32[ss, ebp - 0x20]);   /* movsx ecx, word [ebp-0x20] */
            ii(0x1009_0f6d, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_0f70, 3); sub(eax, memd_a32[ss, ebp - 0x8]);      /* sub eax, [ebp-0x8] */
            ii(0x1009_0f73, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x1009_0f76, 1); inc(eax);                               /* inc eax */
            ii(0x1009_0f77, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_0f7a, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_0f7d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_0f80, 5); calld(0x1009_0aaa, -0x4db);             /* call 0x10090aaa */
            ii(0x1009_0f85, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1009_0f8a, 1); pushd(eax);                             /* push eax */
            ii(0x1009_0f8b, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_0f8e, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1009_0f91, 1); cwde();                                 /* cwde */
            ii(0x1009_0f92, 1); pushd(eax);                             /* push eax */
            ii(0x1009_0f93, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1009_0f97, 1); pushd(eax);                             /* push eax */
            ii(0x1009_0f98, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_0f9b, 3); sub(eax, memd_a32[ss, ebp - 0x8]);      /* sub eax, [ebp-0x8] */
            ii(0x1009_0f9e, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x1009_0fa1, 1); inc(eax);                               /* inc eax */
            ii(0x1009_0fa2, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1009_0fa5, 4); movsx(ebx, memw_a32[ss, ebp - 0x24]);   /* movsx ebx, word [ebp-0x24] */
            ii(0x1009_0fa9, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_0fac, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_0faf, 5); calld(0x1009_0aaa, -0x50a);             /* call 0x10090aaa */
        l_0x1009_0fb4:
            ii(0x1009_0fb4, 5); jmpd(0x1009_0e8e, -0x12b); goto l_0x1009_0e8e; /* jmp 0x10090e8e */
        l_0x1009_0fb9:
            ii(0x1009_0fb9, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_0fbc, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_0fbf, 5); calld(0x1007_6338, -0x1_ac8c);          /* call 0x10076338 */
            ii(0x1009_0fc4, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x1009_0fc7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_0fc9, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_0fcb, 5); calld(0x1007_643c, -0x1_ab94);          /* call 0x1007643c */
            ii(0x1009_0fd0, 2); jmpd(0x1009_0fda, 0x8); goto l_0x1009_0fda; /* jmp 0x10090fda */
        l_0x1009_0fd2:
            ii(0x1009_0fd2, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_0fd5, 5); calld(0x1007_6bf8, -0x1_a3e2);          /* call 0x10076bf8 */
        l_0x1009_0fda:
            ii(0x1009_0fda, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_0fdc, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_0fdf, 5); calld(0x1013_ad71, 0xa_9d8d);           /* call 0x1013ad71 */
            ii(0x1009_0fe4, 2); test(al, al);                           /* test al, al */
            ii(0x1009_0fe6, 6); if(jzd(0x1009_106b, 0x7f)) goto l_0x1009_106b; /* jz 0x1009106b */
            ii(0x1009_0fec, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_0fef, 5); calld(0x1007_63a0, -0x1_ac54);          /* call 0x100763a0 */
            ii(0x1009_0ff4, 5); cmp(memw_a32[ds, eax + 0x8], 0xc);      /* cmp word [eax+0x8], 0xc */
            ii(0x1009_0ff9, 2); if(jzd(0x1009_100a, 0xf)) goto l_0x1009_100a; /* jz 0x1009100a */
            ii(0x1009_0ffb, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_0ffe, 5); calld(0x1007_63a0, -0x1_ac63);          /* call 0x100763a0 */
            ii(0x1009_1003, 5); cmp(memw_a32[ds, eax + 0x8], 0x27);     /* cmp word [eax+0x8], 0x27 */
            ii(0x1009_1008, 2); if(jnzd(0x1009_100c, 0x2)) goto l_0x1009_100c; /* jnz 0x1009100c */
        l_0x1009_100a:
            ii(0x1009_100a, 2); jmpd(0x1009_101b, 0xf); goto l_0x1009_101b; /* jmp 0x1009101b */
        l_0x1009_100c:
            ii(0x1009_100c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_100f, 5); calld(0x1007_63a0, -0x1_ac74);          /* call 0x100763a0 */
            ii(0x1009_1014, 5); cmp(memw_a32[ds, eax + 0x8], 0x21);     /* cmp word [eax+0x8], 0x21 */
            ii(0x1009_1019, 2); if(jnzd(0x1009_101d, 0x2)) goto l_0x1009_101d; /* jnz 0x1009101d */
        l_0x1009_101b:
            ii(0x1009_101b, 2); jmpd(0x1009_1066, 0x49); goto l_0x1009_1066; /* jmp 0x10091066 */
        l_0x1009_101d:
            ii(0x1009_101d, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1009_1020, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_1023, 5); calld(0x1007_63a0, -0x1_ac88);          /* call 0x100763a0 */
            ii(0x1009_1028, 5); calld(0x1015_2532, 0xc_1505);           /* call 0x10152532 */
            ii(0x1009_102d, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1009_1032, 1); pushd(eax);                             /* push eax */
            ii(0x1009_1033, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_1036, 5); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1009_103b, 1); cwde();                                 /* cwde */
            ii(0x1009_103c, 1); pushd(eax);                             /* push eax */
            ii(0x1009_103d, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_1040, 5); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1009_1045, 1); cwde();                                 /* cwde */
            ii(0x1009_1046, 1); pushd(eax);                             /* push eax */
            ii(0x1009_1047, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_104a, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x1009_104d, 1); dec(eax);                               /* dec eax */
            ii(0x1009_104e, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1009_1051, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_1054, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x1009_1057, 1); dec(eax);                               /* dec eax */
            ii(0x1009_1058, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_105b, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_105e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_1061, 5); calld(0x1009_0aaa, -0x5bc);             /* call 0x10090aaa */
        l_0x1009_1066:
            ii(0x1009_1066, 5); jmpd(0x1009_0fd2, -0x99); goto l_0x1009_0fd2; /* jmp 0x10090fd2 */
        l_0x1009_106b:
            ii(0x1009_106b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_106e, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_1071, 5); calld(0x1007_6338, -0x1_ad3e);          /* call 0x10076338 */
            ii(0x1009_1076, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x1009_1079, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_107b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_107d, 5); calld(0x1007_643c, -0x1_ac46);          /* call 0x1007643c */
            ii(0x1009_1082, 2); jmpd(0x1009_108c, 0x8); goto l_0x1009_108c; /* jmp 0x1009108c */
        l_0x1009_1084:
            ii(0x1009_1084, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_1087, 5); calld(0x1007_6bf8, -0x1_a494);          /* call 0x10076bf8 */
        l_0x1009_108c:
            ii(0x1009_108c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_108e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_1091, 5); calld(0x1013_ad71, 0xa_9cdb);           /* call 0x1013ad71 */
            ii(0x1009_1096, 2); test(al, al);                           /* test al, al */
            ii(0x1009_1098, 6); if(jzd(0x1009_113c, 0x9e)) goto l_0x1009_113c; /* jz 0x1009113c */
            ii(0x1009_109e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_10a1, 5); calld(0x1007_63a0, -0x1_ad06);          /* call 0x100763a0 */
            ii(0x1009_10a6, 5); cmp(memw_a32[ds, eax + 0x8], 0xc);      /* cmp word [eax+0x8], 0xc */
            ii(0x1009_10ab, 2); if(jzd(0x1009_10bc, 0xf)) goto l_0x1009_10bc; /* jz 0x100910bc */
            ii(0x1009_10ad, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_10b0, 5); calld(0x1007_63a0, -0x1_ad15);          /* call 0x100763a0 */
            ii(0x1009_10b5, 5); cmp(memw_a32[ds, eax + 0x8], 0x27);     /* cmp word [eax+0x8], 0x27 */
            ii(0x1009_10ba, 2); if(jnzd(0x1009_10be, 0x2)) goto l_0x1009_10be; /* jnz 0x100910be */
        l_0x1009_10bc:
            ii(0x1009_10bc, 2); jmpd(0x1009_10cd, 0xf); goto l_0x1009_10cd; /* jmp 0x100910cd */
        l_0x1009_10be:
            ii(0x1009_10be, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_10c1, 5); calld(0x1007_63a0, -0x1_ad26);          /* call 0x100763a0 */
            ii(0x1009_10c6, 5); cmp(memw_a32[ds, eax + 0x8], 0x21);     /* cmp word [eax+0x8], 0x21 */
            ii(0x1009_10cb, 2); if(jnzd(0x1009_10cf, 0x2)) goto l_0x1009_10cf; /* jnz 0x100910cf */
        l_0x1009_10cd:
            ii(0x1009_10cd, 2); jmpd(0x1009_1137, 0x68); goto l_0x1009_1137; /* jmp 0x10091137 */
        l_0x1009_10cf:
            ii(0x1009_10cf, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1009_10d2, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_10d5, 5); calld(0x1007_63a0, -0x1_ad3a);          /* call 0x100763a0 */
            ii(0x1009_10da, 5); calld(0x1015_2532, 0xc_1453);           /* call 0x10152532 */
            ii(0x1009_10df, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_10e1, 1); pushd(eax);                             /* push eax */
            ii(0x1009_10e2, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1009_10e6, 1); pushd(eax);                             /* push eax */
            ii(0x1009_10e7, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_10ea, 1); inc(eax);                               /* inc eax */
            ii(0x1009_10eb, 1); cwde();                                 /* cwde */
            ii(0x1009_10ec, 1); pushd(eax);                             /* push eax */
            ii(0x1009_10ed, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_10f0, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x1009_10f3, 1); inc(eax);                               /* inc eax */
            ii(0x1009_10f4, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1009_10f7, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_10fa, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x1009_10fd, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_1100, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_1103, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_1106, 5); calld(0x1009_0aaa, -0x661);             /* call 0x10090aaa */
            ii(0x1009_110b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_110d, 1); pushd(eax);                             /* push eax */
            ii(0x1009_110e, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_1111, 1); inc(eax);                               /* inc eax */
            ii(0x1009_1112, 1); cwde();                                 /* cwde */
            ii(0x1009_1113, 1); pushd(eax);                             /* push eax */
            ii(0x1009_1114, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1009_1118, 1); pushd(eax);                             /* push eax */
            ii(0x1009_1119, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_111c, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x1009_111f, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1009_1122, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_1125, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x1009_1128, 1); inc(eax);                               /* inc eax */
            ii(0x1009_1129, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_112c, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_112f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_1132, 5); calld(0x1009_0aaa, -0x68d);             /* call 0x10090aaa */
        l_0x1009_1137:
            ii(0x1009_1137, 5); jmpd(0x1009_1084, -0xb8); goto l_0x1009_1084; /* jmp 0x10091084 */
        l_0x1009_113c:
            ii(0x1009_113c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_113f, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_1142, 5); calld(0x1009_c6c8, 0xb581);             /* call 0x1009c6c8 */
            ii(0x1009_1147, 3); lea(ebx, ebp - 0x28);                   /* lea ebx, [ebp-0x28] */
            ii(0x1009_114a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_114c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_114e, 5); calld(0x1009_c5dc, 0xb489);             /* call 0x1009c5dc */
            ii(0x1009_1153, 2); jmpd(0x1009_115d, 0x8); goto l_0x1009_115d; /* jmp 0x1009115d */
        l_0x1009_1155:
            ii(0x1009_1155, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_1158, 5); calld(0x1007_6bf8, -0x1_a565);          /* call 0x10076bf8 */
        l_0x1009_115d:
            ii(0x1009_115d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_115f, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_1162, 5); calld(0x1013_ad71, 0xa_9c0a);           /* call 0x1013ad71 */
            ii(0x1009_1167, 2); test(al, al);                           /* test al, al */
            ii(0x1009_1169, 6); if(jzd(0x1009_122b, 0xbc)) goto l_0x1009_122b; /* jz 0x1009122b */
            ii(0x1009_116f, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_1172, 5); calld(0x1009_c4f8, 0xb381);             /* call 0x1009c4f8 */
            ii(0x1009_1177, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1009_117a, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1009_117d, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_1180, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1009_1183, 3); calld_abs(memd_a32[ds, edx + 0x70]);    /* call dword [edx+0x70] */
            ii(0x1009_1186, 2); test(al, al);                           /* test al, al */
            ii(0x1009_1188, 2); if(jzd(0x1009_119d, 0x13)) goto l_0x1009_119d; /* jz 0x1009119d */
            ii(0x1009_118a, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_118d, 5); calld(0x1009_c4f8, 0xb366);             /* call 0x1009c4f8 */
            ii(0x1009_1192, 5); calld(0x1009_c4c4, 0xb32d);             /* call 0x1009c4c4 */
            ii(0x1009_1197, 4); cmp(ax, 0x21);                          /* cmp ax, 0x21 */
            ii(0x1009_119b, 2); if(jnzd(0x1009_119f, 0x2)) goto l_0x1009_119f; /* jnz 0x1009119f */
        l_0x1009_119d:
            ii(0x1009_119d, 2); jmpd(0x1009_11b2, 0x13); goto l_0x1009_11b2; /* jmp 0x100911b2 */
        l_0x1009_119f:
            ii(0x1009_119f, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_11a2, 5); calld(0x1009_c4f8, 0xb351);             /* call 0x1009c4f8 */
            ii(0x1009_11a7, 5); calld(0x1009_c4c4, 0xb318);             /* call 0x1009c4c4 */
            ii(0x1009_11ac, 4); cmp(ax, 0x27);                          /* cmp ax, 0x27 */
            ii(0x1009_11b0, 2); if(jnzd(0x1009_11b4, 0x2)) goto l_0x1009_11b4; /* jnz 0x100911b4 */
        l_0x1009_11b2:
            ii(0x1009_11b2, 2); jmpd(0x1009_1226, 0x72); goto l_0x1009_1226; /* jmp 0x10091226 */
        l_0x1009_11b4:
            ii(0x1009_11b4, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_11b7, 5); calld(0x1009_c4f8, 0xb33c);             /* call 0x1009c4f8 */
            ii(0x1009_11bc, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1009_11bf, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1009_11c2, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1009_11c5, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1009_11c8, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1009_11cb, 3); calld_abs(memd_a32[ds, ebx + 0x1c]);    /* call dword [ebx+0x1c] */
            ii(0x1009_11ce, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_11d0, 1); pushd(eax);                             /* push eax */
            ii(0x1009_11d1, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1009_11d5, 1); pushd(eax);                             /* push eax */
            ii(0x1009_11d6, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_11d9, 1); inc(eax);                               /* inc eax */
            ii(0x1009_11da, 1); cwde();                                 /* cwde */
            ii(0x1009_11db, 1); pushd(eax);                             /* push eax */
            ii(0x1009_11dc, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_11df, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x1009_11e2, 1); inc(eax);                               /* inc eax */
            ii(0x1009_11e3, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1009_11e6, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_11e9, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x1009_11ec, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_11ef, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_11f2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_11f5, 5); calld(0x1009_0aaa, -0x750);             /* call 0x10090aaa */
            ii(0x1009_11fa, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_11fc, 1); pushd(eax);                             /* push eax */
            ii(0x1009_11fd, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_1200, 1); inc(eax);                               /* inc eax */
            ii(0x1009_1201, 1); cwde();                                 /* cwde */
            ii(0x1009_1202, 1); pushd(eax);                             /* push eax */
            ii(0x1009_1203, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1009_1207, 1); pushd(eax);                             /* push eax */
            ii(0x1009_1208, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_120b, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x1009_120e, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1009_1211, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_1214, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x1009_1217, 1); inc(eax);                               /* inc eax */
            ii(0x1009_1218, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_121b, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_121e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_1221, 5); calld(0x1009_0aaa, -0x77c);             /* call 0x10090aaa */
        l_0x1009_1226:
            ii(0x1009_1226, 5); jmpd(0x1009_1155, -0xd6); goto l_0x1009_1155; /* jmp 0x10091155 */
        l_0x1009_122b:
            ii(0x1009_122b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_122d, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_1230, 5); calld(0x1009_ba6c, 0xa837);             /* call 0x1009ba6c */
            ii(0x1009_1235, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_1237, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_123a, 5); calld(0x1007_5f6c, -0x1_b2d3);          /* call 0x10075f6c */
            ii(0x1009_123f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_1241, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_1242, 1); popd(edi);                              /* pop edi */
            ii(0x1009_1243, 1); popd(esi);                              /* pop esi */
            ii(0x1009_1244, 1); retd();                                 /* ret */
        }
    }
}
