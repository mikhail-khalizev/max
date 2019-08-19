using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_46e6-c1d4862")]
        public void Method_1008_46e6()
        {
            ii(0x1008_46e6, 5); pushd(0x60);                            /* push 0x60 */
            ii(0x1008_46eb, 5); calld(Definitions.sys_check_available_stack_size, 0xe_1662); /* call 0x10165d52 */
            ii(0x1008_46f0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_46f1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_46f2, 1); pushd(edx);                             /* push edx */
            ii(0x1008_46f3, 1); pushd(esi);                             /* push esi */
            ii(0x1008_46f4, 1); pushd(edi);                             /* push edi */
            ii(0x1008_46f5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_46f6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_46f8, 6); sub(esp, 0x44);                         /* sub esp, 0x44 */
            ii(0x1008_46fe, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_4701, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1008_4705, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1008_4708, 5); calld(0x1008_9c28, 0x551b);             /* call 0x10089c28 */
            ii(0x1008_470d, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1008_4710, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1008_4714, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1008_4718, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1008_471b, 5); calld(0x1007_64fc, -0xe224);            /* call 0x100764fc */
            ii(0x1008_4720, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1008_4723, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1008_4727, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1008_472e, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1008_4735, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1008_4738, 5); calld(Definitions.my_ctor_0x101b_4184, -0xdc4d); /* call 0x10076af0 */
            ii(0x1008_473d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_473f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4742, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_4745, 5); calld(0x1013_ad11, 0xb_65c7);           /* call 0x1013ad11 */
            ii(0x1008_474a, 2); test(al, al);                           /* test al, al */
            ii(0x1008_474c, 2); if(jnzd(0x1008_4762, 0x14)) goto l_0x1008_4762; /* jnz 0x10084762 */
            ii(0x1008_474e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4751, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_4754, 5); calld(0x1008_9d7c, 0x5623);             /* call 0x10089d7c */
            ii(0x1008_4759, 5); calld(0x1008_9f70, 0x5812);             /* call 0x10089f70 */
            ii(0x1008_475e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_4760, 2); if(jnzd(0x1008_477f, 0x1d)) goto l_0x1008_477f; /* jnz 0x1008477f */
        l_0x1008_4762:
            ii(0x1008_4762, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_4766, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_4768, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1008_476b, 5); calld(0x1007_5f6c, -0xe804);            /* call 0x10075f6c */
            ii(0x1008_4770, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_4772, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1008_4775, 5); calld(0x1008_9044, 0x48ca);             /* call 0x10089044 */
            ii(0x1008_477a, 5); jmpd(0x1008_4a0c, 0x28d); goto l_0x1008_4a0c; /* jmp 0x10084a0c */
        l_0x1008_477f:
            ii(0x1008_477f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4782, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_4785, 5); calld(0x1008_9d7c, 0x55f2);             /* call 0x10089d7c */
            ii(0x1008_478a, 5); calld(0x1008_9f70, 0x57e1);             /* call 0x10089f70 */
            ii(0x1008_478f, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1008_4792, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1008_4795, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1008_4799, 4); mov(memw_a32[ss, ebp - 0x2c], ax);      /* mov [ebp-0x2c], ax */
            ii(0x1008_479d, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1008_47a0, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1008_47a4, 4); mov(memw_a32[ss, ebp - 0x2a], ax);      /* mov [ebp-0x2a], ax */
            ii(0x1008_47a8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_47ab, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_47ae, 5); calld(0x1008_9d08, 0x5555);             /* call 0x10089d08 */
            ii(0x1008_47b3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_47b5, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1008_47b8, 5); calld(0x1008_9b68, 0x53ab);             /* call 0x10089b68 */
            ii(0x1008_47bd, 2); jmpd(0x1008_47c7, 0x8); goto l_0x1008_47c7; /* jmp 0x100847c7 */
        l_0x1008_47bf:
            ii(0x1008_47bf, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1008_47c2, 5); calld(0x1007_6bf8, -0xdbcf);            /* call 0x10076bf8 */
        l_0x1008_47c7:
            ii(0x1008_47c7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_47c9, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1008_47cc, 5); calld(0x1013_ad71, 0xb_65a0);           /* call 0x1013ad71 */
            ii(0x1008_47d1, 2); test(al, al);                           /* test al, al */
            ii(0x1008_47d3, 2); if(jzd(0x1008_4833, 0x5e)) goto l_0x1008_4833; /* jz 0x10084833 */
            ii(0x1008_47d5, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1008_47d8, 5); calld(0x1008_9b34, 0x5357);             /* call 0x10089b34 */
            ii(0x1008_47dd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_47df, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_47e2, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_47e5, 5); calld(0x1008_9e08, 0x561e);             /* call 0x10089e08 */
            ii(0x1008_47ea, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_47ec, 2); if(jzd(0x1008_4811, 0x23)) goto l_0x1008_4811; /* jz 0x10084811 */
            ii(0x1008_47ee, 3); lea(edx, ebp - 0x2c);                   /* lea edx, [ebp-0x2c] */
            ii(0x1008_47f1, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1008_47f4, 5); calld(0x1007_5e64, -0xe995);            /* call 0x10075e64 */
            ii(0x1008_47f9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_47fb, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1008_47fe, 5); calld(0x1008_9acc, 0x52c9);             /* call 0x10089acc */
            ii(0x1008_4803, 5); calld(0x1008_9f70, 0x5768);             /* call 0x10089f70 */
            ii(0x1008_4808, 5); calld(0x1008_2d5c, -0x1ab1);            /* call 0x10082d5c */
            ii(0x1008_480d, 2); test(al, al);                           /* test al, al */
            ii(0x1008_480f, 2); if(jzd(0x1008_4821, 0x10)) goto l_0x1008_4821; /* jz 0x10084821 */
        l_0x1008_4811:
            ii(0x1008_4811, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1008_4814, 5); calld(0x1008_9acc, 0x52b3);             /* call 0x10089acc */
            ii(0x1008_4819, 5); calld(0x1008_9ffc, 0x57de);             /* call 0x10089ffc */
            ii(0x1008_481e, 3); add(memd_a32[ss, ebp - 0x18], eax);     /* add [ebp-0x18], eax */
        l_0x1008_4821:
            ii(0x1008_4821, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1008_4824, 5); calld(0x1008_9acc, 0x52a3);             /* call 0x10089acc */
            ii(0x1008_4829, 5); calld(0x1007_b032, -0x97fc);            /* call 0x1007b032 */
            ii(0x1008_482e, 3); add(memd_a32[ss, ebp - 0x10], eax);     /* add [ebp-0x10], eax */
            ii(0x1008_4831, 2); jmpd(0x1008_47bf, -0x74); goto l_0x1008_47bf; /* jmp 0x100847bf */
        l_0x1008_4833:
            ii(0x1008_4833, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_4836, 4); cmp(ax, memw_a32[ss, ebp - 0x18]);      /* cmp ax, [ebp-0x18] */
            ii(0x1008_483a, 2); if(jged(0x1008_4859, 0x1d)) goto l_0x1008_4859; /* jge 0x10084859 */
            ii(0x1008_483c, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_4840, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_4842, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1008_4845, 5); calld(0x1007_5f6c, -0xe8de);            /* call 0x10075f6c */
            ii(0x1008_484a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_484c, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1008_484f, 5); calld(0x1008_9044, 0x47f0);             /* call 0x10089044 */
            ii(0x1008_4854, 5); jmpd(0x1008_4a0c, 0x1b3); goto l_0x1008_4a0c; /* jmp 0x10084a0c */
        l_0x1008_4859:
            ii(0x1008_4859, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_485c, 3); mov(edx, memd_a32[ds, eax + 0x7]);      /* mov edx, [eax+0x7] */
            ii(0x1008_485f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_4862, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_4865, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_4868, 5); calld(0x1008_9d7c, 0x550f);             /* call 0x10089d7c */
            ii(0x1008_486d, 5); calld(0x1008_9f70, 0x56fe);             /* call 0x10089f70 */
            ii(0x1008_4872, 5); calld(0x1007_6074, -0xe803);            /* call 0x10076074 */
            ii(0x1008_4877, 2); test(al, al);                           /* test al, al */
            ii(0x1008_4879, 2); if(jzd(0x1008_4898, 0x1d)) goto l_0x1008_4898; /* jz 0x10084898 */
            ii(0x1008_487b, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_487f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_4881, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1008_4884, 5); calld(0x1007_5f6c, -0xe91d);            /* call 0x10075f6c */
            ii(0x1008_4889, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_488b, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1008_488e, 5); calld(0x1008_9044, 0x47b1);             /* call 0x10089044 */
            ii(0x1008_4893, 5); jmpd(0x1008_4a0c, 0x174); goto l_0x1008_4a0c; /* jmp 0x10084a0c */
        l_0x1008_4898:
            ii(0x1008_4898, 7); mov(memd_a32[ss, ebp - 0x24], 0);       /* mov dword [ebp-0x24], 0x0 */
            ii(0x1008_489f, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1008_48a6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_48a8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_48ab, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_48ae, 5); calld(0x1013_ad71, 0xb_64be);           /* call 0x1013ad71 */
            ii(0x1008_48b3, 2); test(al, al);                           /* test al, al */
            ii(0x1008_48b5, 2); if(jzd(0x1008_48d9, 0x22)) goto l_0x1008_48d9; /* jz 0x100848d9 */
            ii(0x1008_48b7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_48ba, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_48bd, 5); calld(0x1007_6574, -0xe34e);            /* call 0x10076574 */
            ii(0x1008_48c2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_48c4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_48c7, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_48ca, 5); calld(0x1007_6574, -0xe35b);            /* call 0x10076574 */
            ii(0x1008_48cf, 4); mov(dx, memw_a32[ds, edx + 0x1a]);      /* mov dx, [edx+0x1a] */
            ii(0x1008_48d3, 4); cmp(dx, memw_a32[ds, eax + 0x1e]);      /* cmp dx, [eax+0x1e] */
            ii(0x1008_48d7, 2); if(jzd(0x1008_48db, 0x2)) goto l_0x1008_48db; /* jz 0x100848db */
        l_0x1008_48d9:
            ii(0x1008_48d9, 2); jmpd(0x1008_48fd, 0x22); goto l_0x1008_48fd; /* jmp 0x100848fd */
        l_0x1008_48db:
            ii(0x1008_48db, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_48de, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_48e1, 5); calld(0x1007_6574, -0xe372);            /* call 0x10076574 */
            ii(0x1008_48e6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_48e8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_48eb, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_48ee, 5); calld(0x1007_6574, -0xe37f);            /* call 0x10076574 */
            ii(0x1008_48f3, 4); mov(dx, memw_a32[ds, edx + 0x1c]);      /* mov dx, [edx+0x1c] */
            ii(0x1008_48f7, 4); cmp(dx, memw_a32[ds, eax + 0x20]);      /* cmp dx, [eax+0x20] */
            ii(0x1008_48fb, 2); if(jzd(0x1008_48ff, 0x2)) goto l_0x1008_48ff; /* jz 0x100848ff */
        l_0x1008_48fd:
            ii(0x1008_48fd, 2); jmpd(0x1008_491c, 0x1d); goto l_0x1008_491c; /* jmp 0x1008491c */
        l_0x1008_48ff:
            ii(0x1008_48ff, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_4903, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_4905, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1008_4908, 5); calld(0x1007_5f6c, -0xe9a1);            /* call 0x10075f6c */
            ii(0x1008_490d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_490f, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1008_4912, 5); calld(0x1008_9044, 0x472d);             /* call 0x10089044 */
            ii(0x1008_4917, 5); jmpd(0x1008_4a0c, 0xf0); goto l_0x1008_4a0c; /* jmp 0x10084a0c */
        l_0x1008_491c:
            ii(0x1008_491c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_491f, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_4922, 5); calld(0x1008_9d08, 0x53e1);             /* call 0x10089d08 */
            ii(0x1008_4927, 3); lea(ebx, ebp - 0x3c);                   /* lea ebx, [ebp-0x3c] */
            ii(0x1008_492a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_492c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_492e, 5); calld(0x1008_9b68, 0x5235);             /* call 0x10089b68 */
            ii(0x1008_4933, 2); jmpd(0x1008_493d, 0x8); goto l_0x1008_493d; /* jmp 0x1008493d */
        l_0x1008_4935:
            ii(0x1008_4935, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1008_4938, 5); calld(0x1007_6bf8, -0xdd45);            /* call 0x10076bf8 */
        l_0x1008_493d:
            ii(0x1008_493d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_493f, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1008_4942, 5); calld(0x1013_ad71, 0xb_642a);           /* call 0x1013ad71 */
            ii(0x1008_4947, 2); test(al, al);                           /* test al, al */
            ii(0x1008_4949, 6); if(jzd(0x1008_49c9, 0x7a)) goto l_0x1008_49c9; /* jz 0x100849c9 */
            ii(0x1008_494f, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1008_4952, 5); calld(0x1008_9acc, 0x5175);             /* call 0x10089acc */
            ii(0x1008_4957, 5); calld(0x1008_9fc4, 0x5668);             /* call 0x10089fc4 */
            ii(0x1008_495c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_495e, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1008_4961, 5); calld(0x1007_643c, -0xe52a);            /* call 0x1007643c */
            ii(0x1008_4966, 2); jmpd(0x1008_4970, 0x8); goto l_0x1008_4970; /* jmp 0x10084970 */
        l_0x1008_4968:
            ii(0x1008_4968, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1008_496b, 5); calld(0x1007_6bf8, -0xdd78);            /* call 0x10076bf8 */
        l_0x1008_4970:
            ii(0x1008_4970, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_4972, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1008_4975, 5); calld(0x1013_ad71, 0xb_63f7);           /* call 0x1013ad71 */
            ii(0x1008_497a, 2); test(al, al);                           /* test al, al */
            ii(0x1008_497c, 2); if(jzd(0x1008_49c4, 0x46)) goto l_0x1008_49c4; /* jz 0x100849c4 */
            ii(0x1008_497e, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1008_4981, 5); calld(0x1007_63d4, -0xe5b2);            /* call 0x100763d4 */
            ii(0x1008_4986, 5); calld(0x1007_6ec0, -0xdacb);            /* call 0x10076ec0 */
            ii(0x1008_498b, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1008_498e, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1008_4991, 5); calld(0x1007_63a0, -0xe5f6);            /* call 0x100763a0 */
            ii(0x1008_4996, 5); calld(0x1007_623c, -0xe75f);            /* call 0x1007623c */
            ii(0x1008_499b, 4); mov(ax, memw_a32[ds, eax + 0x17]);      /* mov ax, [eax+0x17] */
            ii(0x1008_499f, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1008_49a2, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1008_49a6, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x1008_49aa, 5); calld(0x1007_6e7c, -0xdb33);            /* call 0x10076e7c */
            ii(0x1008_49af, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1008_49b2, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1008_49b6, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1008_49ba, 5); calld(0x1007_6e7c, -0xdb43);            /* call 0x10076e7c */
            ii(0x1008_49bf, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1008_49c2, 2); jmpd(0x1008_4968, -0x5c); goto l_0x1008_4968; /* jmp 0x10084968 */
        l_0x1008_49c4:
            ii(0x1008_49c4, 5); jmpd(0x1008_4935, -0x94); goto l_0x1008_4935; /* jmp 0x10084935 */
        l_0x1008_49c9:
            ii(0x1008_49c9, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1008_49cc, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x1008_49d0, 2); if(jgd(0x1008_49d8, 0x6)) goto l_0x1008_49d8; /* jg 0x100849d8 */
            ii(0x1008_49d2, 4); mov(memb_a32[ss, ebp - 0x44], 0x1);     /* mov byte [ebp-0x44], 0x1 */
            ii(0x1008_49d6, 2); jmpd(0x1008_49dc, 0x4); goto l_0x1008_49dc; /* jmp 0x100849dc */
        l_0x1008_49d8:
            ii(0x1008_49d8, 4); mov(memb_a32[ss, ebp - 0x44], 0);       /* mov byte [ebp-0x44], 0x0 */
        l_0x1008_49dc:
            ii(0x1008_49dc, 3); mov(al, memb_a32[ss, ebp - 0x44]);      /* mov al, [ebp-0x44] */
            ii(0x1008_49df, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x1008_49e2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_49e4, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1008_49e7, 5); calld(0x1007_5f6c, -0xea80);            /* call 0x10075f6c */
            ii(0x1008_49ec, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_49ee, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1008_49f1, 5); calld(0x1008_9044, 0x464e);             /* call 0x10089044 */
            ii(0x1008_49f6, 2); jmpd(0x1008_4a0c, 0x14); goto l_0x1008_4a0c; /* jmp 0x10084a0c */
        //  ii(0x1008_49f8, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1008_49fa, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
        //  ii(0x1008_49fd, 5); calld(0x1007_5f6c, -0xea96);            /* call 0x10075f6c */
        //  ii(0x1008_4a02, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1008_4a04, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
        //  ii(0x1008_4a07, 5); calld(0x1008_9044, 0x4638);             /* call 0x10089044 */
        l_0x1008_4a0c:
            ii(0x1008_4a0c, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1008_4a0f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_4a11, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_4a12, 1); popd(edi);                              /* pop edi */
            ii(0x1008_4a13, 1); popd(esi);                              /* pop esi */
            ii(0x1008_4a14, 1); popd(edx);                              /* pop edx */
            ii(0x1008_4a15, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_4a16, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_4a17, 1); retd(); return;                         /* ret */
        }
    }
}
