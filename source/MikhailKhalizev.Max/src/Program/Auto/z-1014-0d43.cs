using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_0d43-240ada39")]
        public void Method_1014_0d43()
        {
            ii(0x1014_0d43, 5); pushd(0x428);                           /* push 0x428 */
            ii(0x1014_0d48, 5); calld(Definitions.sys_check_available_stack_size, 0x2_5005); /* call 0x10165d52 */
            ii(0x1014_0d4d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_0d4e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_0d4f, 1); pushd(edx);                             /* push edx */
            ii(0x1014_0d50, 1); pushd(esi);                             /* push esi */
            ii(0x1014_0d51, 1); pushd(edi);                             /* push edi */
            ii(0x1014_0d52, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_0d53, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_0d55, 6); sub(esp, 0x3f4);                        /* sub esp, 0x3f4 */
            ii(0x1014_0d5b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_0d5e, 7); mov(memd_a32[ss, ebp - 0x54], 0);       /* mov dword [ebp-0x54], 0x0 */
            ii(0x1014_0d65, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1014_0d6a, 5); calld(0x1012_0d94, -0x1_ffdb);          /* call 0x10120d94 */
            ii(0x1014_0d6f, 6); lea(edx, ebp - 0x368);                  /* lea edx, [ebp-0x368] */
            ii(0x1014_0d75, 5); mov(eax, 0x6bd);                        /* mov eax, 0x6bd */
            ii(0x1014_0d7a, 5); calld(0x1013_45c2, -0xc7bd);            /* call 0x101345c2 */
            ii(0x1014_0d7f, 2); test(al, al);                           /* test al, al */
            ii(0x1014_0d81, 6); if(jzd(0x1014_1440, 0x6b9)) goto l_0x1014_1440; /* jz 0x10141440 */
            ii(0x1014_0d87, 7); movsx(edx, memw_a32[ss, ebp - 0x364]);  /* movsx edx, word [ebp-0x364] */
            ii(0x1014_0d8e, 5); mov(eax, 0x280);                        /* mov eax, 0x280 */
            ii(0x1014_0d93, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1014_0d95, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_0d97, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_0d99, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1014_0d9c, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1014_0d9e, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1014_0da0, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_0da3, 7); movsx(edx, memw_a32[ss, ebp - 0x362]);  /* movsx edx, word [ebp-0x362] */
            ii(0x1014_0daa, 5); mov(eax, 0x1e0);                        /* mov eax, 0x1e0 */
            ii(0x1014_0daf, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1014_0db1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_0db3, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_0db5, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1014_0db8, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1014_0dba, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1014_0dbc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_0dbf, 10); mov(memd_a32[ss, ebp - 0x384], 0);     /* mov dword [ebp-0x384], 0x0 */
            ii(0x1014_0dc9, 10); mov(memd_a32[ss, ebp - 0x380], 0);     /* mov dword [ebp-0x380], 0x0 */
            ii(0x1014_0dd3, 6); mov(eax, memd_a32[ss, ebp - 0x364]);    /* mov eax, [ebp-0x364] */
            ii(0x1014_0dd9, 7); mov(memw_a32[ss, ebp - 0x374], ax);     /* mov [ebp-0x374], ax */
            ii(0x1014_0de0, 7); movsx(eax, memw_a32[ss, ebp - 0x374]);  /* movsx eax, word [ebp-0x374] */
            ii(0x1014_0de7, 6); mov(memd_a32[ss, ebp - 0x37c], eax);    /* mov [ebp-0x37c], eax */
            ii(0x1014_0ded, 7); movsx(eax, memw_a32[ss, ebp - 0x362]);  /* movsx eax, word [ebp-0x362] */
            ii(0x1014_0df4, 6); mov(memd_a32[ss, ebp - 0x378], eax);    /* mov [ebp-0x378], eax */
            ii(0x1014_0dfa, 2); pushd(0);                               /* push 0x0 */
            ii(0x1014_0dfc, 2); pushd(0);                               /* push 0x0 */
            ii(0x1014_0dfe, 7); movsx(ecx, memw_a32[ss, ebp - 0x362]);  /* movsx ecx, word [ebp-0x362] */
            ii(0x1014_0e05, 7); movsx(ebx, memw_a32[ss, ebp - 0x364]);  /* movsx ebx, word [ebp-0x364] */
            ii(0x1014_0e0c, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1014_0e10, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1014_0e14, 5); calld(/* sys */ 0x1016_6764, 0x2_594b); /* call 0x10166764 */
            ii(0x1014_0e19, 6); mov(memd_a32[ss, ebp - 0x372], eax);    /* mov [ebp-0x372], eax */
            ii(0x1014_0e1f, 6); mov(eax, memd_a32[ss, ebp - 0x372]);    /* mov eax, [ebp-0x372] */
            ii(0x1014_0e25, 5); calld(/* sys */ 0x1016_7dd4, 0x2_6faa); /* call 0x10167dd4 */
            ii(0x1014_0e2a, 6); mov(memd_a32[ss, ebp - 0x36e], eax);    /* mov [ebp-0x36e], eax */
            ii(0x1014_0e30, 5); calld(0x100d_533c, -0x6_baf9);          /* call 0x100d533c */
            ii(0x1014_0e35, 1); cwde();                                 /* cwde */
            ii(0x1014_0e36, 1); pushd(eax);                             /* push eax */
            ii(0x1014_0e37, 5); calld(0x100d_5360, -0x6_badc);          /* call 0x100d5360 */
            ii(0x1014_0e3c, 1); cwde();                                 /* cwde */
            ii(0x1014_0e3d, 1); pushd(eax);                             /* push eax */
            ii(0x1014_0e3e, 5); calld(0x100d_5384, -0x6_babf);          /* call 0x100d5384 */
            ii(0x1014_0e43, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_0e48, 1); pushd(eax);                             /* push eax */
            ii(0x1014_0e49, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1014_0e4b, 7); movsx(ebx, memw_a32[ss, ebp - 0x374]);  /* movsx ebx, word [ebp-0x374] */
            ii(0x1014_0e52, 6); lea(edx, ebp - 0x384);                  /* lea edx, [ebp-0x384] */
            ii(0x1014_0e58, 5); mov(eax, 0x6bd);                        /* mov eax, 0x6bd */
            ii(0x1014_0e5d, 5); calld(0x100e_8c51, -0x5_8211);          /* call 0x100e8c51 */
            ii(0x1014_0e62, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1014_0e65, 2); if(jnzd(0x1014_0e77, 0x10)) goto l_0x1014_0e77; /* jnz 0x10140e77 */
            ii(0x1014_0e67, 6); mov(eax, memd_a32[ss, ebp - 0x372]);    /* mov eax, [ebp-0x372] */
            ii(0x1014_0e6d, 5); calld(/* sys */ 0x1016_6990, 0x2_5b1e); /* call 0x10166990 */
            ii(0x1014_0e72, 5); jmpd(0x1014_1440, 0x5c9); goto l_0x1014_1440; /* jmp 0x10141440 */
        l_0x1014_0e77:
            ii(0x1014_0e77, 5); calld(0x100f_fc13, -0x4_1269);          /* call 0x100ffc13 */
            ii(0x1014_0e7c, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1014_0e81, 5); calld(/* sys */ 0x1016_a24c, 0x2_93c6); /* call 0x1016a24c */
            ii(0x1014_0e86, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1014_0e8b, 5); calld(Definitions.sys_new, 0x2_4f70);   /* call 0x10165e00 */
            ii(0x1014_0e90, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1014_0e93, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1014_0e96, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1014_0e99, 4); cmp(memd_a32[ss, ebp - 0x44], 0);       /* cmp dword [ebp-0x44], 0x0 */
            ii(0x1014_0e9d, 2); if(jzd(0x1014_0eca, 0x2b)) goto l_0x1014_0eca; /* jz 0x10140eca */
            ii(0x1014_0e9f, 5); mov(eax, 0x1c4);                        /* mov eax, 0x1c4 */
            ii(0x1014_0ea4, 1); pushd(eax);                             /* push eax */
            ii(0x1014_0ea5, 5); mov(ecx, 0x1e4);                        /* mov ecx, 0x1e4 */
            ii(0x1014_0eaa, 5); mov(ebx, 0x123);                        /* mov ebx, 0x123 */
            ii(0x1014_0eaf, 5); mov(edx, 0x122);                        /* mov edx, 0x122 */
            ii(0x1014_0eb4, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1014_0eb7, 5); calld(Definitions.my_ctor_c17, -0x7_2aad); /* call 0x100ce40f */
            ii(0x1014_0ebc, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1014_0ebf, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1014_0ec2, 6); mov(memd_a32[ss, ebp - 0x388], eax);    /* mov [ebp-0x388], eax */
            ii(0x1014_0ec8, 2); jmpd(0x1014_0ed3, 0x9); goto l_0x1014_0ed3; /* jmp 0x10140ed3 */
        l_0x1014_0eca:
            ii(0x1014_0eca, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1014_0ecd, 6); mov(memd_a32[ss, ebp - 0x388], eax);    /* mov [ebp-0x388], eax */
        l_0x1014_0ed3:
            ii(0x1014_0ed3, 6); mov(eax, memd_a32[ss, ebp - 0x388]);    /* mov eax, [ebp-0x388] */
            ii(0x1014_0ed9, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x1014_0edc, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_0edf, 5); calld(0x100d_5224, -0x6_bcc0);          /* call 0x100d5224 */
            ii(0x1014_0ee4, 1); pushd(eax);                             /* push eax */
            ii(0x1014_0ee5, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1014_0ee8, 5); calld(0x100d_5250, -0x6_bc9d);          /* call 0x100d5250 */
            ii(0x1014_0eed, 1); pushd(eax);                             /* push eax */
            ii(0x1014_0eee, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_0ef1, 5); calld(0x100d_527c, -0x6_bc7a);          /* call 0x100d527c */
            ii(0x1014_0ef6, 1); pushd(eax);                             /* push eax */
            ii(0x1014_0ef7, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1014_0efa, 5); calld(0x100d_52a8, -0x6_bc57);          /* call 0x100d52a8 */
            ii(0x1014_0eff, 1); pushd(eax);                             /* push eax */
            ii(0x1014_0f00, 5); calld(0x100d_52d4, -0x6_bc31);          /* call 0x100d52d4 */
            ii(0x1014_0f05, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1014_0f08, 5); calld(0x100d_52f8, -0x6_bc15);          /* call 0x100d52f8 */
            ii(0x1014_0f0d, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1014_0f10, 5); mov(edx, StringDefinitions.Done2);      /* mov edx, 0x101ace49 */
            ii(0x1014_0f15, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1014_0f18, 5); calld(0x100c_ef64, -0x7_1fb9);          /* call 0x100cef64 */
            ii(0x1014_0f1d, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1014_0f22, 5); calld(Definitions.sys_new, 0x2_4ed9);   /* call 0x10165e00 */
            ii(0x1014_0f27, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1014_0f2a, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1014_0f2d, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1014_0f30, 4); cmp(memd_a32[ss, ebp - 0x34], 0);       /* cmp dword [ebp-0x34], 0x0 */
            ii(0x1014_0f34, 2); if(jzd(0x1014_0f61, 0x2b)) goto l_0x1014_0f61; /* jz 0x10140f61 */
            ii(0x1014_0f36, 5); mov(eax, 0x1c4);                        /* mov eax, 0x1c4 */
            ii(0x1014_0f3b, 1); pushd(eax);                             /* push eax */
            ii(0x1014_0f3c, 5); mov(ecx, 0x1c9);                        /* mov ecx, 0x1c9 */
            ii(0x1014_0f41, 5); mov(ebx, 0x12d);                        /* mov ebx, 0x12d */
            ii(0x1014_0f46, 5); mov(edx, 0x12c);                        /* mov edx, 0x12c */
            ii(0x1014_0f4b, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1014_0f4e, 5); calld(Definitions.my_ctor_c17, -0x7_2b44); /* call 0x100ce40f */
            ii(0x1014_0f53, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1014_0f56, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1014_0f59, 6); mov(memd_a32[ss, ebp - 0x38c], eax);    /* mov [ebp-0x38c], eax */
            ii(0x1014_0f5f, 2); jmpd(0x1014_0f6a, 0x9); goto l_0x1014_0f6a; /* jmp 0x10140f6a */
        l_0x1014_0f61:
            ii(0x1014_0f61, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1014_0f64, 6); mov(memd_a32[ss, ebp - 0x38c], eax);    /* mov [ebp-0x38c], eax */
        l_0x1014_0f6a:
            ii(0x1014_0f6a, 6); mov(eax, memd_a32[ss, ebp - 0x38c]);    /* mov eax, [ebp-0x38c] */
            ii(0x1014_0f70, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x1014_0f73, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1014_0f78, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1014_0f7b, 5); calld(0x100d_5134, -0x6_be4c);          /* call 0x100d5134 */
            ii(0x1014_0f80, 5); mov(edx, 0x3e8);                        /* mov edx, 0x3e8 */
            ii(0x1014_0f85, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1014_0f88, 5); calld(0x100d_5134, -0x6_be59);          /* call 0x100d5134 */
            ii(0x1014_0f8d, 5); mov(edx, 0x700d);                       /* mov edx, 0x700d */
            ii(0x1014_0f92, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1014_0f95, 5); calld(0x100d_5164, -0x6_be36);          /* call 0x100d5164 */
            ii(0x1014_0f9a, 5); mov(edx, 0x73e8);                       /* mov edx, 0x73e8 */
            ii(0x1014_0f9f, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1014_0fa2, 5); calld(0x100d_5164, -0x6_be43);          /* call 0x100d5164 */
            ii(0x1014_0fa7, 5); mov(edx, 0x4e6);                        /* mov edx, 0x4e6 */
            ii(0x1014_0fac, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1014_0faf, 5); calld(0x100d_50d4, -0x6_bee0);          /* call 0x100d50d4 */
            ii(0x1014_0fb4, 5); mov(edx, 0x4e5);                        /* mov edx, 0x4e5 */
            ii(0x1014_0fb9, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1014_0fbc, 5); calld(0x100d_50d4, -0x6_beed);          /* call 0x100d50d4 */
            ii(0x1014_0fc1, 6); mov(edx, memd_a32[ss, ebp - 0x372]);    /* mov edx, [ebp-0x372] */
            ii(0x1014_0fc7, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1014_0fca, 5); calld(0x100c_f85c, -0x7_1773);          /* call 0x100cf85c */
            ii(0x1014_0fcf, 6); mov(edx, memd_a32[ss, ebp - 0x372]);    /* mov edx, [ebp-0x372] */
            ii(0x1014_0fd5, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1014_0fd8, 5); calld(0x100c_f85c, -0x7_1781);          /* call 0x100cf85c */
            ii(0x1014_0fdd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_0fe0, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1014_0fe3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_0fe6, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1014_0fe9, 5); mov(edx, 0x101c_81c0);                  /* mov edx, 0x101c81c0 */
            ii(0x1014_0fee, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1014_0ff0, 3); mov(memd_a32[ss, ebp - 0x2c], edx);     /* mov [ebp-0x2c], edx */
            ii(0x1014_0ff3, 5); mov(ecx, 0x6);                          /* mov ecx, 0x6 */
            ii(0x1014_0ff8, 6); lea(edi, ebp - 0x3a8);                  /* lea edi, [ebp-0x3a8] */
            ii(0x1014_0ffe, 6); lea(esi, ebp - 0x384);                  /* lea esi, [ebp-0x384] */
            ii(0x1014_1004, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x1014_1006, 2); movsw_a32();                            /* movsw */
            ii(0x1014_1008, 7); movsx(eax, memw_a32[ss, ebp - 0x374]);  /* movsx eax, word [ebp-0x374] */
            ii(0x1014_100f, 3); imul(eax, eax, 0xd);                    /* imul eax, eax, 0xd */
            ii(0x1014_1012, 6); mov(edx, memd_a32[ss, ebp - 0x36e]);    /* mov edx, [ebp-0x36e] */
            ii(0x1014_1018, 3); add(edx, 0xb);                          /* add edx, 0xb */
            ii(0x1014_101b, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1014_101d, 6); mov(memd_a32[ss, ebp - 0x392], edx);    /* mov [ebp-0x392], edx */
            ii(0x1014_1023, 10); mov(memd_a32[ss, ebp - 0x3a8], 0xb);   /* mov dword [ebp-0x3a8], 0xb */
            ii(0x1014_102d, 10); mov(memd_a32[ss, ebp - 0x3a4], 0xd);   /* mov dword [ebp-0x3a4], 0xd */
            ii(0x1014_1037, 10); mov(memd_a32[ss, ebp - 0x3a0], 0x137); /* mov dword [ebp-0x3a0], 0x137 */
            ii(0x1014_1041, 10); mov(memd_a32[ss, ebp - 0x39c], 0xfd);  /* mov dword [ebp-0x39c], 0xfd */
            ii(0x1014_104b, 5); mov(eax, memd_a32[ds, 0x101c_810e]);    /* mov eax, [0x101c810e] */
            ii(0x1014_1050, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_1053, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1014_1056, 2); if(jld(0x1014_1064, 0xc)) goto l_0x1014_1064; /* jl 0x10141064 */
            ii(0x1014_1058, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_105b, 5); calld(0x1015_26ac, 0x1_164c);           /* call 0x101526ac */
            ii(0x1014_1060, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_1062, 2); if(jnzd(0x1014_1069, 0x5)) goto l_0x1014_1069; /* jnz 0x10141069 */
        l_0x1014_1064:
            ii(0x1014_1064, 5); jmpd(0x1014_10e5, 0x7c); goto l_0x1014_10e5; /* jmp 0x101410e5 */
        l_0x1014_1069:
            ii(0x1014_1069, 5); mov(eax, 0x4a);                         /* mov eax, 0x4a */
            ii(0x1014_106e, 5); calld(Definitions.sys_new, 0x2_4d8d);   /* call 0x10165e00 */
            ii(0x1014_1073, 6); mov(memd_a32[ss, ebp - 0x3ac], eax);    /* mov [ebp-0x3ac], eax */
            ii(0x1014_1079, 6); mov(eax, memd_a32[ss, ebp - 0x3ac]);    /* mov eax, [ebp-0x3ac] */
            ii(0x1014_107f, 6); mov(memd_a32[ss, ebp - 0x3b0], eax);    /* mov [ebp-0x3b0], eax */
            ii(0x1014_1085, 7); cmp(memd_a32[ss, ebp - 0x3b0], 0);      /* cmp dword [ebp-0x3b0], 0x0 */
            ii(0x1014_108c, 2); if(jzd(0x1014_10ce, 0x40)) goto l_0x1014_10ce; /* jz 0x101410ce */
            ii(0x1014_108e, 5); mov(eax, 0x7d2);                        /* mov eax, 0x7d2 */
            ii(0x1014_1093, 1); pushd(eax);                             /* push eax */
            ii(0x1014_1094, 5); mov(eax, 0x7d1);                        /* mov eax, 0x7d1 */
            ii(0x1014_1099, 1); pushd(eax);                             /* push eax */
            ii(0x1014_109a, 5); mov(ecx, 0x7d0);                        /* mov ecx, 0x7d0 */
            ii(0x1014_109f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_10a2, 5); calld(0x1015_26ac, 0x1_1605);           /* call 0x101526ac */
            ii(0x1014_10a7, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1014_10a9, 6); lea(edx, ebp - 0x3a8);                  /* lea edx, [ebp-0x3a8] */
            ii(0x1014_10af, 6); mov(eax, memd_a32[ss, ebp - 0x3ac]);    /* mov eax, [ebp-0x3ac] */
            ii(0x1014_10b5, 5); calld(0x1014_02bc, -0xdfe);             /* call 0x101402bc */
            ii(0x1014_10ba, 6); mov(memd_a32[ss, ebp - 0x3b4], eax);    /* mov [ebp-0x3b4], eax */
            ii(0x1014_10c0, 6); mov(eax, memd_a32[ss, ebp - 0x3b4]);    /* mov eax, [ebp-0x3b4] */
            ii(0x1014_10c6, 6); mov(memd_a32[ss, ebp - 0x3b8], eax);    /* mov [ebp-0x3b8], eax */
            ii(0x1014_10cc, 2); jmpd(0x1014_10da, 0xc); goto l_0x1014_10da; /* jmp 0x101410da */
        l_0x1014_10ce:
            ii(0x1014_10ce, 6); mov(eax, memd_a32[ss, ebp - 0x3b0]);    /* mov eax, [ebp-0x3b0] */
            ii(0x1014_10d4, 6); mov(memd_a32[ss, ebp - 0x3b8], eax);    /* mov [ebp-0x3b8], eax */
        l_0x1014_10da:
            ii(0x1014_10da, 6); mov(eax, memd_a32[ss, ebp - 0x3b8]);    /* mov eax, [ebp-0x3b8] */
            ii(0x1014_10e0, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x1014_10e3, 2); jmpd(0x1014_114c, 0x67); goto l_0x1014_114c; /* jmp 0x1014114c */
        l_0x1014_10e5:
            ii(0x1014_10e5, 5); calld(0x100d_533c, -0x6_bdae);          /* call 0x100d533c */
            ii(0x1014_10ea, 1); cwde();                                 /* cwde */
            ii(0x1014_10eb, 1); pushd(eax);                             /* push eax */
            ii(0x1014_10ec, 5); calld(0x100d_5360, -0x6_bd91);          /* call 0x100d5360 */
            ii(0x1014_10f1, 1); cwde();                                 /* cwde */
            ii(0x1014_10f2, 1); pushd(eax);                             /* push eax */
            ii(0x1014_10f3, 5); calld(0x100d_5384, -0x6_bd74);          /* call 0x100d5384 */
            ii(0x1014_10f8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_10fd, 1); pushd(eax);                             /* push eax */
            ii(0x1014_10fe, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1014_1100, 7); movsx(ebx, memw_a32[ss, ebp - 0x374]);  /* movsx ebx, word [ebp-0x374] */
            ii(0x1014_1107, 6); lea(edx, ebp - 0x3a8);                  /* lea edx, [ebp-0x3a8] */
            ii(0x1014_110d, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1014_1110, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x1014_1113, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_1116, 5); calld(0x100e_8c51, -0x5_84ca);          /* call 0x100e8c51 */
            ii(0x1014_111b, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1014_111e, 2); if(jnzd(0x1014_114c, 0x2c)) goto l_0x1014_114c; /* jnz 0x1014114c */
            ii(0x1014_1120, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_1122, 1); pushd(eax);                             /* push eax */
            ii(0x1014_1123, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_1125, 1); pushd(eax);                             /* push eax */
            ii(0x1014_1126, 5); mov(eax, 0x4a);                         /* mov eax, 0x4a */
            ii(0x1014_112b, 1); pushd(eax);                             /* push eax */
            ii(0x1014_112c, 5); mov(ecx, 0x64);                         /* mov ecx, 0x64 */
            ii(0x1014_1131, 7); movsx(ebx, memw_a32[ss, ebp - 0x374]);  /* movsx ebx, word [ebp-0x374] */
            ii(0x1014_1138, 6); lea(edx, ebp - 0x384);                  /* lea edx, [ebp-0x384] */
            ii(0x1014_113e, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1014_1141, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1014_1144, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_1147, 5); calld(0x100f_04d8, -0x5_0c74);          /* call 0x100f04d8 */
        l_0x1014_114c:
            ii(0x1014_114c, 5); mov(eax, 0x271);                        /* mov eax, 0x271 */
            ii(0x1014_1151, 1); pushd(eax);                             /* push eax */
            ii(0x1014_1152, 5); mov(eax, 0x270);                        /* mov eax, 0x270 */
            ii(0x1014_1157, 1); pushd(eax);                             /* push eax */
            ii(0x1014_1158, 5); mov(eax, 0xf5);                         /* mov eax, 0xf5 */
            ii(0x1014_115d, 1); pushd(eax);                             /* push eax */
            ii(0x1014_115e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_1161, 5); calld(0x1014_1698, 0x532);              /* call 0x10141698 */
            ii(0x1014_1166, 1); pushd(eax);                             /* push eax */
            ii(0x1014_1167, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_116a, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1014_116d, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_116f, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1014_1172, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_1175, 3); mov(ebx, memd_a32[ds, eax + 0x6]);      /* mov ebx, [eax+0x6] */
            ii(0x1014_1178, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_117b, 7); movsx(edx, memw_a32[ss, ebp - 0x374]);  /* movsx edx, word [ebp-0x374] */
            ii(0x1014_1182, 7); movsx(eax, memw_a32[ss, ebp - 0x374]);  /* movsx eax, word [ebp-0x374] */
            ii(0x1014_1189, 6); imul(eax, eax, 0x125);                  /* imul eax, eax, 0x125 */
            ii(0x1014_118f, 6); mov(esi, memd_a32[ss, ebp - 0x36e]);    /* mov esi, [ebp-0x36e] */
            ii(0x1014_1195, 3); add(esi, 0xb);                          /* add esi, 0xb */
            ii(0x1014_1198, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1014_119a, 5); calld(0x1014_018f, -0x1010);            /* call 0x1014018f */
            ii(0x1014_119f, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1014_11a4, 5); calld(/* sys */ 0x1016_a24c, 0x2_90a3); /* call 0x1016a24c */
            ii(0x1014_11a9, 6); lea(edx, ebp - 0x3e0);                  /* lea edx, [ebp-0x3e0] */
            ii(0x1014_11af, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_11b2, 5); calld(0x1014_fa43, 0xe88c);             /* call 0x1014fa43 */
            ii(0x1014_11b7, 5); calld(0x100d_531c, -0x6_bea0);          /* call 0x100d531c */
            ii(0x1014_11bc, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_11c1, 1); pushd(eax);                             /* push eax */
            ii(0x1014_11c2, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1014_11c7, 1); pushd(eax);                             /* push eax */
            ii(0x1014_11c8, 5); pushd(0xa2);                            /* push 0xa2 */
            ii(0x1014_11cd, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
            ii(0x1014_11d2, 1); pushd(eax);                             /* push eax */
            ii(0x1014_11d3, 5); mov(eax, 0x11f);                        /* mov eax, 0x11f */
            ii(0x1014_11d8, 1); pushd(eax);                             /* push eax */
            ii(0x1014_11d9, 5); mov(eax, 0x3c);                         /* mov eax, 0x3c */
            ii(0x1014_11de, 1); pushd(eax);                             /* push eax */
            ii(0x1014_11df, 5); mov(ecx, 0x150);                        /* mov ecx, 0x150 */
            ii(0x1014_11e4, 6); lea(ebx, ebp - 0x3e0);                  /* lea ebx, [ebp-0x3e0] */
            ii(0x1014_11ea, 7); movsx(edx, memw_a32[ss, ebp - 0x374]);  /* movsx edx, word [ebp-0x374] */
            ii(0x1014_11f1, 6); mov(eax, memd_a32[ss, ebp - 0x36e]);    /* mov eax, [ebp-0x36e] */
            ii(0x1014_11f7, 5); calld(0x100e_9ae5, -0x5_7717);          /* call 0x100e9ae5 */
            ii(0x1014_11fc, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_11fe, 1); pushd(eax);                             /* push eax */
            ii(0x1014_11ff, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_1201, 1); pushd(eax);                             /* push eax */
            ii(0x1014_1202, 5); pushd(0xa2);                            /* push 0xa2 */
            ii(0x1014_1207, 5); mov(eax, 0x75);                         /* mov eax, 0x75 */
            ii(0x1014_120c, 1); pushd(eax);                             /* push eax */
            ii(0x1014_120d, 5); mov(eax, 0x10e);                        /* mov eax, 0x10e */
            ii(0x1014_1212, 1); pushd(eax);                             /* push eax */
            ii(0x1014_1213, 5); mov(eax, 0x5a);                         /* mov eax, 0x5a */
            ii(0x1014_1218, 1); pushd(eax);                             /* push eax */
            ii(0x1014_1219, 5); mov(ecx, 0x159);                        /* mov ecx, 0x159 */
            ii(0x1014_121e, 3); mov(ebx, memd_a32[ss, ebp - 0x2c]);     /* mov ebx, [ebp-0x2c] */
            ii(0x1014_1221, 3); mov(ebx, memd_a32[ds, ebx + 0x1f]);     /* mov ebx, [ebx+0x1f] */
            ii(0x1014_1224, 7); movsx(edx, memw_a32[ss, ebp - 0x374]);  /* movsx edx, word [ebp-0x374] */
            ii(0x1014_122b, 6); mov(eax, memd_a32[ss, ebp - 0x36e]);    /* mov eax, [ebp-0x36e] */
            ii(0x1014_1231, 5); calld(0x100e_9ae5, -0x5_7751);          /* call 0x100e9ae5 */
            ii(0x1014_1236, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1014_123b, 5); calld(/* sys */ 0x1016_a24c, 0x2_900c); /* call 0x1016a24c */
            ii(0x1014_1240, 5); calld(0x100d_531c, -0x6_bf29);          /* call 0x100d531c */
            ii(0x1014_1245, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_124a, 1); pushd(eax);                             /* push eax */
            ii(0x1014_124b, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1014_1250, 1); pushd(eax);                             /* push eax */
            ii(0x1014_1251, 2); pushd(0x2);                             /* push 0x2 */
            ii(0x1014_1253, 5); mov(eax, 0x12);                         /* mov eax, 0x12 */
            ii(0x1014_1258, 1); pushd(eax);                             /* push eax */
            ii(0x1014_1259, 5); mov(eax, 0x9e);                         /* mov eax, 0x9e */
            ii(0x1014_125e, 1); pushd(eax);                             /* push eax */
            ii(0x1014_125f, 5); mov(eax, 0x7);                          /* mov eax, 0x7 */
            ii(0x1014_1264, 1); pushd(eax);                             /* push eax */
            ii(0x1014_1265, 5); mov(ecx, 0x147);                        /* mov ecx, 0x147 */
            ii(0x1014_126a, 5); mov(ebx, StringDefinitions.UnitStatusScreen); /* mov ebx, 0x101ace4e */
            ii(0x1014_126f, 7); movsx(edx, memw_a32[ss, ebp - 0x374]);  /* movsx edx, word [ebp-0x374] */
            ii(0x1014_1276, 6); mov(eax, memd_a32[ss, ebp - 0x36e]);    /* mov eax, [ebp-0x36e] */
            ii(0x1014_127c, 5); calld(0x100e_9ae5, -0x5_779c);          /* call 0x100e9ae5 */
            ii(0x1014_1281, 4); cmp(memd_a32[ss, ebp - 0x54], 0);       /* cmp dword [ebp-0x54], 0x0 */
            ii(0x1014_1285, 2); if(jzd(0x1014_128f, 0x8)) goto l_0x1014_128f; /* jz 0x1014128f */
            ii(0x1014_1287, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x1014_128a, 5); calld(0x1014_0958, -0x937);             /* call 0x10140958 */
        l_0x1014_128f:
            ii(0x1014_128f, 6); mov(eax, memd_a32[ss, ebp - 0x372]);    /* mov eax, [ebp-0x372] */
            ii(0x1014_1295, 5); calld(Definitions.sys_display_draw_0, 0x2_61ea); /* call 0x10167484 */
            ii(0x1014_129a, 7); mov(memd_a32[ss, ebp - 0x3c], 0);       /* mov dword [ebp-0x3c], 0x0 */
            ii(0x1014_12a1, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x1014_12a5:
            ii(0x1014_12a5, 4); cmp(memd_a32[ss, ebp - 0x3c], 0xd);     /* cmp dword [ebp-0x3c], 0xd */
            ii(0x1014_12a9, 2); if(jzd(0x1014_12b1, 0x6)) goto l_0x1014_12b1; /* jz 0x101412b1 */
            ii(0x1014_12ab, 4); cmp(memd_a32[ss, ebp - 0x3c], 0x1b);    /* cmp dword [ebp-0x3c], 0x1b */
            ii(0x1014_12af, 2); if(jnzd(0x1014_12b6, 0x5)) goto l_0x1014_12b6; /* jnz 0x101412b6 */
        l_0x1014_12b1:
            ii(0x1014_12b1, 5); jmpd(0x1014_1376, 0xc0); goto l_0x1014_1376; /* jmp 0x10141376 */
        l_0x1014_12b6:
            ii(0x1014_12b6, 5); calld(/* sys */ 0x1016_b208, 0x2_9f4d); /* call 0x1016b208 */
            ii(0x1014_12bb, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1014_12be, 4); cmp(memd_a32[ss, ebp - 0x3c], 0);       /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x1014_12c2, 2); if(jled(0x1014_12cd, 0x9)) goto l_0x1014_12cd; /* jle 0x101412cd */
            ii(0x1014_12c4, 7); cmp(memd_a32[ss, ebp - 0x3c], 0x7000);  /* cmp dword [ebp-0x3c], 0x7000 */
            ii(0x1014_12cb, 2); if(jld(0x1014_12cf, 0x2)) goto l_0x1014_12cf; /* jl 0x101412cf */
        l_0x1014_12cd:
            ii(0x1014_12cd, 2); jmpd(0x1014_12d3, 0x4); goto l_0x1014_12d3; /* jmp 0x101412d3 */
        l_0x1014_12cf:
            ii(0x1014_12cf, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x1014_12d3:
            ii(0x1014_12d3, 7); cmp(memd_a32[ss, ebp - 0x3c], 0x7000);  /* cmp dword [ebp-0x3c], 0x7000 */
            ii(0x1014_12da, 2); if(jld(0x1014_1306, 0x2a)) goto l_0x1014_1306; /* jl 0x10141306 */
            ii(0x1014_12dc, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1014_12e0, 2); if(jnzd(0x1014_1301, 0x1f)) goto l_0x1014_1301; /* jnz 0x10141301 */
            ii(0x1014_12e2, 7); cmp(memd_a32[ss, ebp - 0x3c], 0x700d);  /* cmp dword [ebp-0x3c], 0x700d */
            ii(0x1014_12e9, 2); if(jnzd(0x1014_12f5, 0xa)) goto l_0x1014_12f5; /* jnz 0x101412f5 */
            ii(0x1014_12eb, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1014_12ee, 5); calld(0x100c_fbbe, -0x7_1735);          /* call 0x100cfbbe */
            ii(0x1014_12f3, 2); jmpd(0x1014_12fd, 0x8); goto l_0x1014_12fd; /* jmp 0x101412fd */
        l_0x1014_12f5:
            ii(0x1014_12f5, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1014_12f8, 5); calld(0x100c_fbbe, -0x7_173f);          /* call 0x100cfbbe */
        l_0x1014_12fd:
            ii(0x1014_12fd, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
        l_0x1014_1301:
            ii(0x1014_1301, 5); jmpd(0x1014_1371, 0x6b); goto l_0x1014_1371; /* jmp 0x10141371 */
        l_0x1014_1306:
            ii(0x1014_1306, 7); cmp(memd_a32[ss, ebp - 0x3c], 0x119);   /* cmp dword [ebp-0x3c], 0x119 */
            ii(0x1014_130d, 2); if(jnzd(0x1014_1314, 0x5)) goto l_0x1014_1314; /* jnz 0x10141314 */
            ii(0x1014_130f, 5); calld(0x1011_6ba6, -0x2_a76e);          /* call 0x10116ba6 */
        l_0x1014_1314:
            ii(0x1014_1314, 7); cmp(memd_a32[ss, ebp - 0x3c], 0x3e8);   /* cmp dword [ebp-0x3c], 0x3e8 */
            ii(0x1014_131b, 2); if(jzd(0x1014_1323, 0x6)) goto l_0x1014_1323; /* jz 0x10141323 */
            ii(0x1014_131d, 4); cmp(memd_a32[ss, ebp - 0x3c], 0x3f);    /* cmp dword [ebp-0x3c], 0x3f */
            ii(0x1014_1321, 2); if(jnzd(0x1014_1338, 0x15)) goto l_0x1014_1338; /* jnz 0x10141338 */
        l_0x1014_1323:
            ii(0x1014_1323, 5); calld(0x100d_4e6c, -0x6_c4bc);          /* call 0x100d4e6c */
            ii(0x1014_1328, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_132a, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1014_132c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_132e, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1014_1333, 5); calld(0x1010_5b00, -0x3_b838);          /* call 0x10105b00 */
        l_0x1014_1338:
            ii(0x1014_1338, 4); cmp(memd_a32[ss, ebp - 0x54], 0);       /* cmp dword [ebp-0x54], 0x0 */
            ii(0x1014_133c, 2); if(jzd(0x1014_1344, 0x6)) goto l_0x1014_1344; /* jz 0x10141344 */
            ii(0x1014_133e, 4); cmp(memd_a32[ss, ebp - 0x3c], 0);       /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x1014_1342, 2); if(jged(0x1014_1346, 0x2)) goto l_0x1014_1346; /* jge 0x10141346 */
        l_0x1014_1344:
            ii(0x1014_1344, 2); jmpd(0x1014_1351, 0xb); goto l_0x1014_1351; /* jmp 0x10141351 */
        l_0x1014_1346:
            ii(0x1014_1346, 3); mov(edx, memd_a32[ss, ebp - 0x3c]);     /* mov edx, [ebp-0x3c] */
            ii(0x1014_1349, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x1014_134c, 5); calld(0x1014_06b0, -0xca1);             /* call 0x101406b0 */
        l_0x1014_1351:
            ii(0x1014_1351, 7); cmp(memb_a32[ds, 0x101c_37d2], 0);      /* cmp byte [0x101c37d2], 0x0 */
            ii(0x1014_1358, 2); if(jzd(0x1014_1361, 0x7)) goto l_0x1014_1361; /* jz 0x10141361 */
            ii(0x1014_135a, 7); mov(memd_a32[ss, ebp - 0x3c], 0xd);     /* mov dword [ebp-0x3c], 0xd */
        l_0x1014_1361:
            ii(0x1014_1361, 5); calld(0x100d_5094, -0x6_c2d2);          /* call 0x100d5094 */
            ii(0x1014_1366, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_1368, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1014_136a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_136c, 5); calld(0x1010_0e32, -0x4_053f);          /* call 0x10100e32 */
        l_0x1014_1371:
            ii(0x1014_1371, 5); jmpd(0x1014_12a5, -0xd1); goto l_0x1014_12a5; /* jmp 0x101412a5 */
        l_0x1014_1376:
            ii(0x1014_1376, 4); cmp(memd_a32[ss, ebp - 0x54], 0);       /* cmp dword [ebp-0x54], 0x0 */
            ii(0x1014_137a, 2); if(jzd(0x1014_13c2, 0x46)) goto l_0x1014_13c2; /* jz 0x101413c2 */
            ii(0x1014_137c, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x1014_137f, 6); mov(memd_a32[ss, ebp - 0x3e4], eax);    /* mov [ebp-0x3e4], eax */
            ii(0x1014_1385, 7); cmp(memd_a32[ss, ebp - 0x3e4], 0);      /* cmp dword [ebp-0x3e4], 0x0 */
            ii(0x1014_138c, 2); if(jzd(0x1014_13b8, 0x2a)) goto l_0x1014_13b8; /* jz 0x101413b8 */
            ii(0x1014_138e, 6); mov(eax, memd_a32[ss, ebp - 0x3e4]);    /* mov eax, [ebp-0x3e4] */
            ii(0x1014_1394, 6); mov(memd_a32[ss, ebp - 0x3e8], eax);    /* mov [ebp-0x3e8], eax */
            ii(0x1014_139a, 6); mov(eax, memd_a32[ss, ebp - 0x3e8]);    /* mov eax, [ebp-0x3e8] */
            ii(0x1014_13a0, 3); mov(ebx, memd_a32[ds, eax + 0x46]);     /* mov ebx, [eax+0x46] */
            ii(0x1014_13a3, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1014_13a8, 6); mov(eax, memd_a32[ss, ebp - 0x3e8]);    /* mov eax, [ebp-0x3e8] */
            ii(0x1014_13ae, 2); calld_abs(memd_a32[ds, ebx]);           /* call dword [ebx] */
            ii(0x1014_13b0, 6); mov(memd_a32[ss, ebp - 0x3ec], eax);    /* mov [ebp-0x3ec], eax */
            ii(0x1014_13b6, 2); jmpd(0x1014_13c2, 0xa); goto l_0x1014_13c2; /* jmp 0x101413c2 */
        l_0x1014_13b8:
            ii(0x1014_13b8, 10); mov(memd_a32[ss, ebp - 0x3ec], 0);     /* mov dword [ebp-0x3ec], 0x0 */
        l_0x1014_13c2:
            ii(0x1014_13c2, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1014_13c5, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1014_13c8, 4); cmp(memd_a32[ss, ebp - 0x28], 0);       /* cmp dword [ebp-0x28], 0x0 */
            ii(0x1014_13cc, 2); if(jzd(0x1014_13e5, 0x17)) goto l_0x1014_13e5; /* jz 0x101413e5 */
            ii(0x1014_13ce, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_13d0, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1014_13d3, 5); calld(Definitions.my_dtor_d2, -0x7_2ea0); /* call 0x100ce538 */
            ii(0x1014_13d8, 5); calld(Definitions.sys_delete, 0x2_4b87); /* call 0x10165f64 */
            ii(0x1014_13dd, 6); mov(memd_a32[ss, ebp - 0x3f0], eax);    /* mov [ebp-0x3f0], eax */
            ii(0x1014_13e3, 2); jmpd(0x1014_13ef, 0xa); goto l_0x1014_13ef; /* jmp 0x101413ef */
        l_0x1014_13e5:
            ii(0x1014_13e5, 10); mov(memd_a32[ss, ebp - 0x3f0], 0);     /* mov dword [ebp-0x3f0], 0x0 */
        l_0x1014_13ef:
            ii(0x1014_13ef, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1014_13f2, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1014_13f5, 4); cmp(memd_a32[ss, ebp - 0x24], 0);       /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1014_13f9, 2); if(jzd(0x1014_1412, 0x17)) goto l_0x1014_1412; /* jz 0x10141412 */
            ii(0x1014_13fb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_13fd, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1014_1400, 5); calld(Definitions.my_dtor_d2, -0x7_2ecd); /* call 0x100ce538 */
            ii(0x1014_1405, 5); calld(Definitions.sys_delete, 0x2_4b5a); /* call 0x10165f64 */
            ii(0x1014_140a, 6); mov(memd_a32[ss, ebp - 0x3f4], eax);    /* mov [ebp-0x3f4], eax */
            ii(0x1014_1410, 2); jmpd(0x1014_141c, 0xa); goto l_0x1014_141c; /* jmp 0x1014141c */
        l_0x1014_1412:
            ii(0x1014_1412, 10); mov(memd_a32[ss, ebp - 0x3f4], 0);     /* mov dword [ebp-0x3f4], 0x0 */
        l_0x1014_141c:
            ii(0x1014_141c, 6); mov(eax, memd_a32[ss, ebp - 0x372]);    /* mov eax, [ebp-0x372] */
            ii(0x1014_1422, 5); calld(/* sys */ 0x1016_6990, 0x2_5569); /* call 0x10166990 */
            ii(0x1014_1427, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x1014_142c, 5); calld(0x1007_6600, -0xc_ae31);          /* call 0x10076600 */
            ii(0x1014_1431, 5); calld(0x100f_fa70, -0x4_19c6);          /* call 0x100ffa70 */
            ii(0x1014_1436, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1014_143b, 5); calld(0x1010_0efe, -0x4_0542);          /* call 0x10100efe */
        l_0x1014_1440:
            ii(0x1014_1440, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_1442, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_1443, 1); popd(edi);                              /* pop edi */
            ii(0x1014_1444, 1); popd(esi);                              /* pop esi */
            ii(0x1014_1445, 1); popd(edx);                              /* pop edx */
            ii(0x1014_1446, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_1447, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_1448, 1); retd();                                 /* ret */
        }
    }
}
