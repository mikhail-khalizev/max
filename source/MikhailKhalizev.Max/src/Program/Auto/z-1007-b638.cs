using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_b638-b3cabf34")]
        public void Method_1007_b638()
        {
            ii(0x1007_b638, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1007_b63d, 5); calld(Definitions.sys_check_available_stack_size, 0xe_a710); /* call 0x10165d52 */
            ii(0x1007_b642, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_b643, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_b644, 1); pushd(edx);                             /* push edx */
            ii(0x1007_b645, 1); pushd(esi);                             /* push esi */
            ii(0x1007_b646, 1); pushd(edi);                             /* push edi */
            ii(0x1007_b647, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_b648, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_b64a, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1007_b650, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_b653, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b656, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1007_b659, 5); calld(0x1008_afb4, 0xf956);             /* call 0x1008afb4 */
            ii(0x1007_b65e, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1007_b661, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1007_b668, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1007_b66b, 5); calld(0x1008_98f8, 0xe288);             /* call 0x100898f8 */
            ii(0x1007_b670, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_b673, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_b675, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b678, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_b67b, 5); calld(0x1013_ad11, 0xb_f691);           /* call 0x1013ad11 */
            ii(0x1007_b680, 2); test(al, al);                           /* test al, al */
            ii(0x1007_b682, 6); if(jnzd(0x1007_b889, 0x201)) goto l_0x1007_b889; /* jnz 0x1007b889 */
            ii(0x1007_b688, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1007_b68d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b690, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_b693, 5); calld(0x1008_a228, 0xeb90);             /* call 0x1008a228 */
            ii(0x1007_b698, 5); calld(0x1008_a370, 0xecd3);             /* call 0x1008a370 */
            ii(0x1007_b69d, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1007_b69f, 3); lea(edx, ebp - 0xc);                    /* lea edx, [ebp-0xc] */
            ii(0x1007_b6a2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b6a5, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1007_b6a8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_b6ab, 6); imul(esi, eax, 0xc5);                   /* imul esi, eax, 0xc5 */
            ii(0x1007_b6b1, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x1007_b6b6, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1007_b6b8, 5); calld(0x100c_317c, 0x4_7abf);           /* call 0x100c317c */
            ii(0x1007_b6bd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_b6bf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b6c2, 3); add(eax, 0x2d);                         /* add eax, 0x2d */
            ii(0x1007_b6c5, 5); calld(0x100b_854d, 0x3_ce83);           /* call 0x100b854d */
            ii(0x1007_b6ca, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_b6cc, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1007_b6cf, 5); calld(0x1008_8dcc, 0xd6f8);             /* call 0x10088dcc */
            ii(0x1007_b6d4, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1007_b6db, 2); jmpd(0x1007_b6e3, 0x6); goto l_0x1007_b6e3; /* jmp 0x1007b6e3 */
        l_0x1007_b6dd:
            ii(0x1007_b6dd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_b6e0, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x1007_b6e3:
            ii(0x1007_b6e3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b6e6, 3); add(eax, 0x2d);                         /* add eax, 0x2d */
            ii(0x1007_b6e9, 5); calld(0x1008_a4a0, 0xedb2);             /* call 0x1008a4a0 */
            ii(0x1007_b6ee, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1007_b6f2, 6); if(jled(0x1007_b777, 0x7f)) goto l_0x1007_b777; /* jle 0x1007b777 */
            ii(0x1007_b6f8, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1007_b6fc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b6ff, 3); add(eax, 0x2d);                         /* add eax, 0x2d */
            ii(0x1007_b702, 5); calld(0x1008_a3dc, 0xecd5);             /* call 0x1008a3dc */
            ii(0x1007_b707, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1007_b709, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_b70c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_b70e, 2); if(jled(0x1007_b772, 0x62)) goto l_0x1007_b772; /* jle 0x1007b772 */
            ii(0x1007_b710, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1007_b714, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b717, 3); add(eax, 0x2d);                         /* add eax, 0x2d */
            ii(0x1007_b71a, 5); calld(0x1008_a3dc, 0xecbd);             /* call 0x1008a3dc */
            ii(0x1007_b71f, 4); cmp(memw_a32[ds, eax], 0x32);           /* cmp word [eax], 0x32 */
            ii(0x1007_b723, 2); if(jnzd(0x1007_b744, 0x1f)) goto l_0x1007_b744; /* jnz 0x1007b744 */
            ii(0x1007_b725, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b728, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1007_b72b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_b72e, 6); imul(edx, eax, 0xc5);                   /* imul edx, eax, 0xc5 */
            ii(0x1007_b734, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x1007_b739, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_b73b, 5); calld(0x1008_a064, 0xe924);             /* call 0x1008a064 */
            ii(0x1007_b740, 2); cmp(al, 0x5);                           /* cmp al, 0x5 */
            ii(0x1007_b742, 2); if(jnzd(0x1007_b746, 0x2)) goto l_0x1007_b746; /* jnz 0x1007b746 */
        l_0x1007_b744:
            ii(0x1007_b744, 2); jmpd(0x1007_b74f, 0x9); goto l_0x1007_b74f; /* jmp 0x1007b74f */
        l_0x1007_b746:
            ii(0x1007_b746, 7); or(memd_a32[ss, ebp - 0x14], 0x100);    /* or dword [ebp-0x14], 0x100 */
            ii(0x1007_b74d, 2); jmpd(0x1007_b772, 0x23); goto l_0x1007_b772; /* jmp 0x1007b772 */
        l_0x1007_b74f:
            ii(0x1007_b74f, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1007_b753, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b756, 3); add(eax, 0x2d);                         /* add eax, 0x2d */
            ii(0x1007_b759, 5); calld(0x1008_a3dc, 0xec7e);             /* call 0x1008a3dc */
            ii(0x1007_b75e, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1007_b761, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1007_b764, 6); mov(eax, memd_a32[ds, eax + 0x101c_81c0]); /* mov eax, [eax+0x101c81c0] */
            ii(0x1007_b76a, 5); and(eax, 0x1c0);                        /* and eax, 0x1c0 */
            ii(0x1007_b76f, 3); or(memd_a32[ss, ebp - 0x14], eax);      /* or [ebp-0x14], eax */
        l_0x1007_b772:
            ii(0x1007_b772, 5); jmpd(0x1007_b6dd, -0x9a); goto l_0x1007_b6dd; /* jmp 0x1007b6dd */
        l_0x1007_b777:
            ii(0x1007_b777, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b77a, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_b77d, 5); calld(0x1008_a228, 0xeaa6);             /* call 0x1008a228 */
            ii(0x1007_b782, 5); calld(0x1008_a370, 0xebe9);             /* call 0x1008a370 */
            ii(0x1007_b787, 4); test(memb_a32[ds, eax + 0x12], 0x40);   /* test byte [eax+0x12], 0x40 */
            ii(0x1007_b78b, 2); if(jzd(0x1007_b791, 0x4)) goto l_0x1007_b791; /* jz 0x1007b791 */
            ii(0x1007_b78d, 4); or(memd_a32[ss, ebp - 0x10], 0x40);     /* or dword [ebp-0x10], 0x40 */
        l_0x1007_b791:
            ii(0x1007_b791, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1007_b794, 3); test(memd_a32[ss, ebp - 0x10], eax);    /* test [ebp-0x10], eax */
            ii(0x1007_b797, 2); if(jzd(0x1007_b7a1, 0x8)) goto l_0x1007_b7a1; /* jz 0x1007b7a1 */
            ii(0x1007_b799, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_b79c, 3); and(memd_a32[ss, ebp - 0x14], eax);     /* and [ebp-0x14], eax */
            ii(0x1007_b79f, 2); jmpd(0x1007_b7ba, 0x19); goto l_0x1007_b7ba; /* jmp 0x1007b7ba */
        l_0x1007_b7a1:
            ii(0x1007_b7a1, 7); test(memd_a32[ss, ebp - 0x14], 0x40);   /* test dword [ebp-0x14], 0x40 */
            ii(0x1007_b7a8, 2); if(jzd(0x1007_b7b3, 0x9)) goto l_0x1007_b7b3; /* jz 0x1007b7b3 */
            ii(0x1007_b7aa, 7); mov(memd_a32[ss, ebp - 0x14], 0x40);    /* mov dword [ebp-0x14], 0x40 */
            ii(0x1007_b7b1, 2); jmpd(0x1007_b7ba, 0x7); goto l_0x1007_b7ba; /* jmp 0x1007b7ba */
        l_0x1007_b7b3:
            ii(0x1007_b7b3, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
        l_0x1007_b7ba:
            ii(0x1007_b7ba, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1007_b7c1, 2); jmpd(0x1007_b7c9, 0x6); goto l_0x1007_b7c9; /* jmp 0x1007b7c9 */
        l_0x1007_b7c3:
            ii(0x1007_b7c3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_b7c6, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x1007_b7c9:
            ii(0x1007_b7c9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b7cc, 3); add(eax, 0x2d);                         /* add eax, 0x2d */
            ii(0x1007_b7cf, 5); calld(0x1008_a4a0, 0xeccc);             /* call 0x1008a4a0 */
            ii(0x1007_b7d4, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1007_b7d8, 6); if(jled(0x1007_b889, 0xab)) goto l_0x1007_b889; /* jle 0x1007b889 */
            ii(0x1007_b7de, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1007_b7e2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b7e5, 3); add(eax, 0x2d);                         /* add eax, 0x2d */
            ii(0x1007_b7e8, 5); calld(0x1008_a3dc, 0xebef);             /* call 0x1008a3dc */
            ii(0x1007_b7ed, 4); cmp(memw_a32[ds, eax], 0x42);           /* cmp word [eax], 0x42 */
            ii(0x1007_b7f1, 6); if(jzd(0x1007_b884, 0x8d)) goto l_0x1007_b884; /* jz 0x1007b884 */
            ii(0x1007_b7f7, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1007_b7fb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b7fe, 3); add(eax, 0x2d);                         /* add eax, 0x2d */
            ii(0x1007_b801, 5); calld(0x1008_a3dc, 0xebd6);             /* call 0x1008a3dc */
            ii(0x1007_b806, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1007_b809, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1007_b80c, 6); mov(eax, memd_a32[ds, eax + 0x101c_81c0]); /* mov eax, [eax+0x101c81c0] */
            ii(0x1007_b812, 3); test(memd_a32[ss, ebp - 0x14], eax);    /* test [ebp-0x14], eax */
            ii(0x1007_b815, 2); if(jnzd(0x1007_b82e, 0x17)) goto l_0x1007_b82e; /* jnz 0x1007b82e */
            ii(0x1007_b817, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1007_b81b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b81e, 3); add(eax, 0x2d);                         /* add eax, 0x2d */
            ii(0x1007_b821, 5); calld(0x1008_a3dc, 0xebb6);             /* call 0x1008a3dc */
            ii(0x1007_b826, 6); mov(memw_a32[ds, eax + 0x2], 0);        /* mov word [eax+0x2], 0x0 */
            ii(0x1007_b82c, 2); jmpd(0x1007_b884, 0x56); goto l_0x1007_b884; /* jmp 0x1007b884 */
        l_0x1007_b82e:
            ii(0x1007_b82e, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1007_b832, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b835, 3); add(eax, 0x2d);                         /* add eax, 0x2d */
            ii(0x1007_b838, 5); calld(0x1008_a3dc, 0xeb9f);             /* call 0x1008a3dc */
            ii(0x1007_b83d, 4); cmp(memw_a32[ds, eax], 0x32);           /* cmp word [eax], 0x32 */
            ii(0x1007_b841, 2); if(jnzd(0x1007_b84c, 0x9)) goto l_0x1007_b84c; /* jnz 0x1007b84c */
            ii(0x1007_b843, 7); test(memd_a32[ss, ebp - 0x14], 0x100);  /* test dword [ebp-0x14], 0x100 */
            ii(0x1007_b84a, 2); if(jzd(0x1007_b84e, 0x2)) goto l_0x1007_b84e; /* jz 0x1007b84e */
        l_0x1007_b84c:
            ii(0x1007_b84c, 2); jmpd(0x1007_b86d, 0x1f); goto l_0x1007_b86d; /* jmp 0x1007b86d */
        l_0x1007_b84e:
            ii(0x1007_b84e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b851, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1007_b854, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_b857, 6); imul(edx, eax, 0xc5);                   /* imul edx, eax, 0xc5 */
            ii(0x1007_b85d, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x1007_b862, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_b864, 5); calld(0x1008_a064, 0xe7fb);             /* call 0x1008a064 */
            ii(0x1007_b869, 2); cmp(al, 0x5);                           /* cmp al, 0x5 */
            ii(0x1007_b86b, 2); if(jnzd(0x1007_b86f, 0x2)) goto l_0x1007_b86f; /* jnz 0x1007b86f */
        l_0x1007_b86d:
            ii(0x1007_b86d, 2); jmpd(0x1007_b884, 0x15); goto l_0x1007_b884; /* jmp 0x1007b884 */
        l_0x1007_b86f:
            ii(0x1007_b86f, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1007_b873, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b876, 3); add(eax, 0x2d);                         /* add eax, 0x2d */
            ii(0x1007_b879, 5); calld(0x1008_a3dc, 0xeb5e);             /* call 0x1008a3dc */
            ii(0x1007_b87e, 6); mov(memw_a32[ds, eax + 0x2], 0);        /* mov word [eax+0x2], 0x0 */
        l_0x1007_b884:
            ii(0x1007_b884, 5); jmpd(0x1007_b7c3, -0xc6); goto l_0x1007_b7c3; /* jmp 0x1007b7c3 */
        l_0x1007_b889:
            ii(0x1007_b889, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_b88b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_b88c, 1); popd(edi);                              /* pop edi */
            ii(0x1007_b88d, 1); popd(esi);                              /* pop esi */
            ii(0x1007_b88e, 1); popd(edx);                              /* pop edx */
            ii(0x1007_b88f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_b890, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_b891, 1); retd();                                 /* ret */
        }
    }
}
