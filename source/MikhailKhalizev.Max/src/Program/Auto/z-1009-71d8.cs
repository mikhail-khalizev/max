using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("307fa6f2-d650-406b-bcf9-2e7b49b5ce98")]
        public void Method_1009_71d8()
        {
            ii(0x1009_71d8, 5); pushd(0x5c);                            /* push 0x5c */
            ii(0x1009_71dd, 5); calld(Definitions.sys_check_available_stack_size, 0xc_eb70); /* call 0x10165d52 */
            ii(0x1009_71e2, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_71e3, 1); pushd(esi);                             /* push esi */
            ii(0x1009_71e4, 1); pushd(edi);                             /* push edi */
            ii(0x1009_71e5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_71e6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_71e8, 6); sub(esp, 0x48);                         /* sub esp, 0x48 */
            ii(0x1009_71ee, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_71f1, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1009_71f4, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1009_71f7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_71fa, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_71fd, 5); calld(0x1007_6338, -0x2_0eca);          /* call 0x10076338 */
            ii(0x1009_7202, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_7204, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_7207, 5); calld(0x1007_64b8, -0x2_0d54);          /* call 0x100764b8 */
            ii(0x1009_720c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_720f, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_7212, 5); calld(0x1009_c6c8, 0x54b1);             /* call 0x1009c6c8 */
            ii(0x1009_7217, 3); lea(ebx, ebp - 0x28);                   /* lea ebx, [ebp-0x28] */
            ii(0x1009_721a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_721c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_721e, 5); calld(0x1009_c5dc, 0x53b9);             /* call 0x1009c5dc */
            ii(0x1009_7223, 7); mov(memd_a32[ss, ebp - 0x20], 0xffff_ffff); /* mov dword [ebp-0x20], 0xffffffff */
            ii(0x1009_722a, 2); jmpd(0x1009_7234, 0x8); goto l_0x1009_7234; /* jmp 0x10097234 */
        l_0x1009_722c:
            ii(0x1009_722c, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_722f, 5); calld(0x1007_6bf8, -0x2_063c);          /* call 0x10076bf8 */
        l_0x1009_7234:
            ii(0x1009_7234, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_7236, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_7239, 5); calld(0x1013_ad71, 0xa_3b33);           /* call 0x1013ad71 */
            ii(0x1009_723e, 2); test(al, al);                           /* test al, al */
            ii(0x1009_7240, 6); if(jzd(0x1009_731e, 0xd8)) goto l_0x1009_731e; /* jz 0x1009731e */
            ii(0x1009_7246, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_7249, 5); calld(0x1007_63a0, -0x2_0eae);          /* call 0x100763a0 */
            ii(0x1009_724e, 5); cmp(memw_a32[ds, eax + 0x8], 0x21);     /* cmp word [eax+0x8], 0x21 */
            ii(0x1009_7253, 2); if(jzd(0x1009_7264, 0xf)) goto l_0x1009_7264; /* jz 0x10097264 */
            ii(0x1009_7255, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_7258, 5); calld(0x1007_63a0, -0x2_0ebd);          /* call 0x100763a0 */
            ii(0x1009_725d, 5); cmp(memw_a32[ds, eax + 0x8], 0x27);     /* cmp word [eax+0x8], 0x27 */
            ii(0x1009_7262, 2); if(jnzd(0x1009_7266, 0x2)) goto l_0x1009_7266; /* jnz 0x10097266 */
        l_0x1009_7264:
            ii(0x1009_7264, 2); jmpd(0x1009_7275, 0xf); goto l_0x1009_7275; /* jmp 0x10097275 */
        l_0x1009_7266:
            ii(0x1009_7266, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_7269, 5); calld(0x1007_63a0, -0x2_0ece);          /* call 0x100763a0 */
            ii(0x1009_726e, 5); cmp(memw_a32[ds, eax + 0x8], 0xc);      /* cmp word [eax+0x8], 0xc */
            ii(0x1009_7273, 2); if(jnzd(0x1009_727a, 0x5)) goto l_0x1009_727a; /* jnz 0x1009727a */
        l_0x1009_7275:
            ii(0x1009_7275, 5); jmpd(0x1009_7319, 0x9f); goto l_0x1009_7319; /* jmp 0x10097319 */
        l_0x1009_727a:
            ii(0x1009_727a, 3); lea(edx, ebp - 0x38);                   /* lea edx, [ebp-0x38] */
            ii(0x1009_727d, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_7280, 5); calld(0x1007_63a0, -0x2_0ee5);          /* call 0x100763a0 */
            ii(0x1009_7285, 5); calld(0x1015_2532, 0xb_b2a8);           /* call 0x10152532 */
            ii(0x1009_728a, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_728d, 5); calld(0x1007_63a0, -0x2_0ef2);          /* call 0x100763a0 */
            ii(0x1009_7292, 5); cmp(memw_a32[ds, eax + 0x8], 0x28);     /* cmp word [eax+0x8], 0x28 */
            ii(0x1009_7297, 2); if(jnzd(0x1009_72a0, 0x7)) goto l_0x1009_72a0; /* jnz 0x100972a0 */
            ii(0x1009_7299, 5); cmp(memw_a32[ss, ebp - 0x20], 0x28);    /* cmp word [ebp-0x20], 0x28 */
            ii(0x1009_729e, 2); if(jnzd(0x1009_72a2, 0x2)) goto l_0x1009_72a2; /* jnz 0x100972a2 */
        l_0x1009_72a0:
            ii(0x1009_72a0, 2); jmpd(0x1009_72a9, 0x7); goto l_0x1009_72a9; /* jmp 0x100972a9 */
        l_0x1009_72a2:
            ii(0x1009_72a2, 7); mov(memd_a32[ss, ebp - 0x20], 0xffff_ffff); /* mov dword [ebp-0x20], 0xffffffff */
        l_0x1009_72a9:
            ii(0x1009_72a9, 5); cmp(memw_a32[ss, ebp - 0x20], -0x1 /* 0xff */); /* cmp word [ebp-0x20], 0xffff */
            ii(0x1009_72ae, 2); if(jnzd(0x1009_72d2, 0x22)) goto l_0x1009_72d2; /* jnz 0x100972d2 */
            ii(0x1009_72b0, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_72b3, 5); calld(0x1007_63a0, -0x2_0f18);          /* call 0x100763a0 */
            ii(0x1009_72b8, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1009_72bc, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1009_72bf, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1009_72c2, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_72c5, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
            ii(0x1009_72c8, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1009_72cb, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_72ce, 4); mov(memw_a32[ds, edx + 0x2], ax);       /* mov [edx+0x2], ax */
        l_0x1009_72d2:
            ii(0x1009_72d2, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1009_72d5, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_72d8, 2); jmpd(0x1009_72e0, 0x6); goto l_0x1009_72e0; /* jmp 0x100972e0 */
        l_0x1009_72da:
            ii(0x1009_72da, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_72dd, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
        l_0x1009_72e0:
            ii(0x1009_72e0, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1009_72e4, 3); cmp(eax, memd_a32[ss, ebp - 0x30]);     /* cmp eax, [ebp-0x30] */
            ii(0x1009_72e7, 2); if(jged(0x1009_7319, 0x30)) goto l_0x1009_7319; /* jge 0x10097319 */
            ii(0x1009_72e9, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1009_72ec, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1009_72ef, 2); jmpd(0x1009_72f7, 0x6); goto l_0x1009_72f7; /* jmp 0x100972f7 */
        l_0x1009_72f1:
            ii(0x1009_72f1, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_72f4, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x1009_72f7:
            ii(0x1009_72f7, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1009_72fb, 3); cmp(eax, memd_a32[ss, ebp - 0x2c]);     /* cmp eax, [ebp-0x2c] */
            ii(0x1009_72fe, 2); if(jged(0x1009_7317, 0x17)) goto l_0x1009_7317; /* jge 0x10097317 */
            ii(0x1009_7300, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1009_7304, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_7307, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1009_730a, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1009_730e, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_7310, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_7312, 3); mov(memb_a32[ds, eax], 0x2);            /* mov byte [eax], 0x2 */
            ii(0x1009_7315, 2); jmpd(0x1009_72f1, -0x26); goto l_0x1009_72f1; /* jmp 0x100972f1 */
        l_0x1009_7317:
            ii(0x1009_7317, 2); jmpd(0x1009_72da, -0x3f); goto l_0x1009_72da; /* jmp 0x100972da */
        l_0x1009_7319:
            ii(0x1009_7319, 5); jmpd(0x1009_722c, -0xf2); goto l_0x1009_722c; /* jmp 0x1009722c */
        l_0x1009_731e:
            ii(0x1009_731e, 2); jmpd(0x1009_7328, 0x8); goto l_0x1009_7328; /* jmp 0x10097328 */
        l_0x1009_7320:
            ii(0x1009_7320, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_7323, 5); calld(0x1007_6bf8, -0x2_0730);          /* call 0x10076bf8 */
        l_0x1009_7328:
            ii(0x1009_7328, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_732a, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_732d, 5); calld(0x1013_ad71, 0xa_3a3f);           /* call 0x1013ad71 */
            ii(0x1009_7332, 2); test(al, al);                           /* test al, al */
            ii(0x1009_7334, 6); if(jzd(0x1009_7420, 0xe6)) goto l_0x1009_7420; /* jz 0x10097420 */
            ii(0x1009_733a, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_733d, 5); calld(0x1009_c4f8, 0x51b6);             /* call 0x1009c4f8 */
            ii(0x1009_7342, 5); calld(0x1009_c4c4, 0x517d);             /* call 0x1009c4c4 */
            ii(0x1009_7347, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_734a, 5); cmp(memw_a32[ss, ebp - 0x14], 0x21);    /* cmp word [ebp-0x14], 0x21 */
            ii(0x1009_734f, 2); if(jzd(0x1009_7358, 0x7)) goto l_0x1009_7358; /* jz 0x10097358 */
            ii(0x1009_7351, 5); cmp(memw_a32[ss, ebp - 0x14], 0x27);    /* cmp word [ebp-0x14], 0x27 */
            ii(0x1009_7356, 2); if(jnzd(0x1009_735a, 0x2)) goto l_0x1009_735a; /* jnz 0x1009735a */
        l_0x1009_7358:
            ii(0x1009_7358, 2); jmpd(0x1009_7361, 0x7); goto l_0x1009_7361; /* jmp 0x10097361 */
        l_0x1009_735a:
            ii(0x1009_735a, 5); cmp(memw_a32[ss, ebp - 0x14], 0xc);     /* cmp word [ebp-0x14], 0xc */
            ii(0x1009_735f, 2); if(jnzd(0x1009_7363, 0x2)) goto l_0x1009_7363; /* jnz 0x10097363 */
        l_0x1009_7361:
            ii(0x1009_7361, 2); jmpd(0x1009_737e, 0x1b); goto l_0x1009_737e; /* jmp 0x1009737e */
        l_0x1009_7363:
            ii(0x1009_7363, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_7366, 5); calld(0x1009_c4f8, 0x518d);             /* call 0x1009c4f8 */
            ii(0x1009_736b, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1009_736e, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1009_7371, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_7374, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1009_7377, 3); calld_abs(memd_a32[ds, edx + 0x70]);    /* call dword [edx+0x70] */
            ii(0x1009_737a, 2); test(al, al);                           /* test al, al */
            ii(0x1009_737c, 2); if(jnzd(0x1009_7383, 0x5)) goto l_0x1009_7383; /* jnz 0x10097383 */
        l_0x1009_737e:
            ii(0x1009_737e, 5); jmpd(0x1009_741b, 0x98); goto l_0x1009_741b; /* jmp 0x1009741b */
        l_0x1009_7383:
            ii(0x1009_7383, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_7386, 5); calld(0x1009_c4f8, 0x516d);             /* call 0x1009c4f8 */
            ii(0x1009_738b, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1009_738e, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1009_7391, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1009_7394, 3); lea(edx, ebp - 0x38);                   /* lea edx, [ebp-0x38] */
            ii(0x1009_7397, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1009_739a, 3); calld_abs(memd_a32[ds, ebx + 0x1c]);    /* call dword [ebx+0x1c] */
            ii(0x1009_739d, 5); cmp(memw_a32[ss, ebp - 0x14], 0x28);    /* cmp word [ebp-0x14], 0x28 */
            ii(0x1009_73a2, 2); if(jnzd(0x1009_73ab, 0x7)) goto l_0x1009_73ab; /* jnz 0x100973ab */
            ii(0x1009_73a4, 5); cmp(memw_a32[ss, ebp - 0x20], 0x28);    /* cmp word [ebp-0x20], 0x28 */
            ii(0x1009_73a9, 2); if(jnzd(0x1009_73ad, 0x2)) goto l_0x1009_73ad; /* jnz 0x100973ad */
        l_0x1009_73ab:
            ii(0x1009_73ab, 2); jmpd(0x1009_73b4, 0x7); goto l_0x1009_73b4; /* jmp 0x100973b4 */
        l_0x1009_73ad:
            ii(0x1009_73ad, 7); mov(memd_a32[ss, ebp - 0x20], 0xffff_ffff); /* mov dword [ebp-0x20], 0xffffffff */
        l_0x1009_73b4:
            ii(0x1009_73b4, 5); cmp(memw_a32[ss, ebp - 0x20], -0x1 /* 0xff */); /* cmp word [ebp-0x20], 0xffff */
            ii(0x1009_73b9, 2); if(jnzd(0x1009_73d4, 0x19)) goto l_0x1009_73d4; /* jnz 0x100973d4 */
            ii(0x1009_73bb, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_73be, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1009_73c1, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1009_73c4, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_73c7, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
            ii(0x1009_73ca, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1009_73cd, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_73d0, 4); mov(memw_a32[ds, edx + 0x2], ax);       /* mov [edx+0x2], ax */
        l_0x1009_73d4:
            ii(0x1009_73d4, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1009_73d7, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_73da, 2); jmpd(0x1009_73e2, 0x6); goto l_0x1009_73e2; /* jmp 0x100973e2 */
        l_0x1009_73dc:
            ii(0x1009_73dc, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_73df, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
        l_0x1009_73e2:
            ii(0x1009_73e2, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1009_73e6, 3); cmp(eax, memd_a32[ss, ebp - 0x30]);     /* cmp eax, [ebp-0x30] */
            ii(0x1009_73e9, 2); if(jged(0x1009_741b, 0x30)) goto l_0x1009_741b; /* jge 0x1009741b */
            ii(0x1009_73eb, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1009_73ee, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1009_73f1, 2); jmpd(0x1009_73f9, 0x6); goto l_0x1009_73f9; /* jmp 0x100973f9 */
        l_0x1009_73f3:
            ii(0x1009_73f3, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_73f6, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x1009_73f9:
            ii(0x1009_73f9, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1009_73fd, 3); cmp(eax, memd_a32[ss, ebp - 0x2c]);     /* cmp eax, [ebp-0x2c] */
            ii(0x1009_7400, 2); if(jged(0x1009_7419, 0x17)) goto l_0x1009_7419; /* jge 0x10097419 */
            ii(0x1009_7402, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1009_7406, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_7409, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1009_740c, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1009_7410, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_7412, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_7414, 3); mov(memb_a32[ds, eax], 0x4);            /* mov byte [eax], 0x4 */
            ii(0x1009_7417, 2); jmpd(0x1009_73f3, -0x26); goto l_0x1009_73f3; /* jmp 0x100973f3 */
        l_0x1009_7419:
            ii(0x1009_7419, 2); jmpd(0x1009_73dc, -0x3f); goto l_0x1009_73dc; /* jmp 0x100973dc */
        l_0x1009_741b:
            ii(0x1009_741b, 5); jmpd(0x1009_7320, -0x100); goto l_0x1009_7320; /* jmp 0x10097320 */
        l_0x1009_7420:
            ii(0x1009_7420, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_7423, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_7426, 5); calld(0x1007_6338, -0x2_10f3);          /* call 0x10076338 */
            ii(0x1009_742b, 3); lea(ebx, ebp - 0x24);                   /* lea ebx, [ebp-0x24] */
            ii(0x1009_742e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_7430, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_7432, 5); calld(0x1007_643c, -0x2_0ffb);          /* call 0x1007643c */
            ii(0x1009_7437, 2); jmpd(0x1009_7441, 0x8); goto l_0x1009_7441; /* jmp 0x10097441 */
        l_0x1009_7439:
            ii(0x1009_7439, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_743c, 5); calld(0x1007_6bf8, -0x2_0849);          /* call 0x10076bf8 */
        l_0x1009_7441:
            ii(0x1009_7441, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_7443, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_7446, 5); calld(0x1013_ad71, 0xa_3926);           /* call 0x1013ad71 */
            ii(0x1009_744b, 2); test(al, al);                           /* test al, al */
            ii(0x1009_744d, 2); if(jzd(0x1009_748b, 0x3c)) goto l_0x1009_748b; /* jz 0x1009748b */
            ii(0x1009_744f, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_7452, 5); calld(0x1007_63a0, -0x2_10b7);          /* call 0x100763a0 */
            ii(0x1009_7457, 5); cmp(memw_a32[ds, eax + 0x8], 0xc);      /* cmp word [eax+0x8], 0xc */
            ii(0x1009_745c, 2); if(jnzd(0x1009_7489, 0x2b)) goto l_0x1009_7489; /* jnz 0x10097489 */
            ii(0x1009_745e, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_7461, 5); calld(0x1007_63a0, -0x2_10c6);          /* call 0x100763a0 */
            ii(0x1009_7466, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1009_7469, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_746c, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_746f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_7472, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_7474, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_7477, 5); calld(0x1007_63a0, -0x2_10dc);          /* call 0x100763a0 */
            ii(0x1009_747c, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x1009_747f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_7482, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1009_7484, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_7486, 3); mov(memb_a32[ds, eax], 0x2);            /* mov byte [eax], 0x2 */
        l_0x1009_7489:
            ii(0x1009_7489, 2); jmpd(0x1009_7439, -0x52); goto l_0x1009_7439; /* jmp 0x10097439 */
        l_0x1009_748b:
            ii(0x1009_748b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_748e, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_7491, 5); calld(0x1009_c6c8, 0x5232);             /* call 0x1009c6c8 */
            ii(0x1009_7496, 3); lea(ebx, ebp - 0x28);                   /* lea ebx, [ebp-0x28] */
            ii(0x1009_7499, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_749b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_749d, 5); calld(0x1009_c560, 0x50be);             /* call 0x1009c560 */
            ii(0x1009_74a2, 2); jmpd(0x1009_74ac, 0x8); goto l_0x1009_74ac; /* jmp 0x100974ac */
        l_0x1009_74a4:
            ii(0x1009_74a4, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_74a7, 5); calld(0x1007_6bf8, -0x2_08b4);          /* call 0x10076bf8 */
        l_0x1009_74ac:
            ii(0x1009_74ac, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_74ae, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_74b1, 5); calld(0x1013_ad71, 0xa_38bb);           /* call 0x1013ad71 */
            ii(0x1009_74b6, 2); test(al, al);                           /* test al, al */
            ii(0x1009_74b8, 2); if(jzd(0x1009_74fa, 0x40)) goto l_0x1009_74fa; /* jz 0x100974fa */
            ii(0x1009_74ba, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_74bd, 5); calld(0x1009_c4f8, 0x5036);             /* call 0x1009c4f8 */
            ii(0x1009_74c2, 5); calld(0x1009_c4c4, 0x4ffd);             /* call 0x1009c4c4 */
            ii(0x1009_74c7, 4); cmp(ax, 0xc);                           /* cmp ax, 0xc */
            ii(0x1009_74cb, 2); if(jnzd(0x1009_74f8, 0x2b)) goto l_0x1009_74f8; /* jnz 0x100974f8 */
            ii(0x1009_74cd, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_74d0, 5); calld(0x1009_c4f8, 0x5023);             /* call 0x1009c4f8 */
            ii(0x1009_74d5, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1009_74d8, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1009_74db, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1009_74de, 3); lea(edx, ebp - 0x38);                   /* lea edx, [ebp-0x38] */
            ii(0x1009_74e1, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1009_74e4, 3); calld_abs(memd_a32[ds, ebx + 0x1c]);    /* call dword [ebx+0x1c] */
            ii(0x1009_74e7, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1009_74ea, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_74ed, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1009_74f0, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_74f2, 3); add(eax, memd_a32[ss, ebp - 0x34]);     /* add eax, [ebp-0x34] */
            ii(0x1009_74f5, 3); mov(memb_a32[ds, eax], 0x2);            /* mov byte [eax], 0x2 */
        l_0x1009_74f8:
            ii(0x1009_74f8, 2); jmpd(0x1009_74a4, -0x56); goto l_0x1009_74a4; /* jmp 0x100974a4 */
        l_0x1009_74fa:
            ii(0x1009_74fa, 5); cmp(memw_a32[ss, ebp - 0x20], -0x1 /* 0xff */); /* cmp word [ebp-0x20], 0xffff */
            ii(0x1009_74ff, 2); if(jzd(0x1009_7507, 0x6)) goto l_0x1009_7507; /* jz 0x10097507 */
            ii(0x1009_7501, 4); mov(memb_a32[ss, ebp - 0x48], 0x1);     /* mov byte [ebp-0x48], 0x1 */
            ii(0x1009_7505, 2); jmpd(0x1009_750b, 0x4); goto l_0x1009_750b; /* jmp 0x1009750b */
        l_0x1009_7507:
            ii(0x1009_7507, 4); mov(memb_a32[ss, ebp - 0x48], 0);       /* mov byte [ebp-0x48], 0x0 */
        l_0x1009_750b:
            ii(0x1009_750b, 3); mov(al, memb_a32[ss, ebp - 0x48]);      /* mov al, [ebp-0x48] */
            ii(0x1009_750e, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1009_7511, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_7513, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_7516, 5); calld(0x1009_ba6c, 0x4551);             /* call 0x1009ba6c */
            ii(0x1009_751b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_751d, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_7520, 5); calld(0x1007_5f6c, -0x2_15b9);          /* call 0x10075f6c */
            ii(0x1009_7525, 2); jmpd(0x1009_753b, 0x14); goto l_0x1009_753b; /* jmp 0x1009753b */
        //    ii(0x1009_7527, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1009_7529, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
        //    ii(0x1009_752c, 5); calld(0x1009_ba6c, 0x453b);             /* call 0x1009ba6c */
        //    ii(0x1009_7531, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1009_7533, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
        //    ii(0x1009_7536, 5); calld(0x1007_5f6c, -0x2_15cf);          /* call 0x10075f6c */
        l_0x1009_753b:
            ii(0x1009_753b, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1009_753e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_7540, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_7541, 1); popd(edi);                              /* pop edi */
            ii(0x1009_7542, 1); popd(esi);                              /* pop esi */
            ii(0x1009_7543, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_7544, 1); retd(); return;                         /* ret */
        }
    }
}
