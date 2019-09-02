using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_b5f3-5dfbf29b")]
        public void Method_100a_b5f3()
        {
            ii(0x100a_b5f3, 5); push(0x60);                             /* push 0x60 */
            ii(0x100a_b5f8, 5); call(Definitions.sys_check_available_stack_size, 0xb_a755); /* call 0x10165d52 */
            ii(0x100a_b5fd, 1); push(ebx);                              /* push ebx */
            ii(0x100a_b5fe, 1); push(ecx);                              /* push ecx */
            ii(0x100a_b5ff, 1); push(esi);                              /* push esi */
            ii(0x100a_b600, 1); push(edi);                              /* push edi */
            ii(0x100a_b601, 1); push(ebp);                              /* push ebp */
            ii(0x100a_b602, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b604, 6); sub(esp, 0x48);                         /* sub esp, 0x48 */
            ii(0x100a_b60a, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_b60d, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_b610, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_b613, 3); mov(al, memb[ds, eax + 80]);            /* mov al, [eax+0x50] */
            ii(0x100a_b616, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_b61b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_b61d, 2); if(jz(0x100a_b62d, 0xe)) goto l_0x100a_b62d; /* jz 0x100ab62d */
            ii(0x100a_b61f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_b622, 5); call(0x1007_623c, -0x3_53eb);           /* call 0x1007623c */
            ii(0x100a_b627, 4); cmp(memb[ds, eax + 22], 0);             /* cmp byte [eax+0x16], 0x0 */
            ii(0x100a_b62b, 2); if(jz(0x100a_b636, 9)) goto l_0x100a_b636; /* jz 0x100ab636 */
        l_0x100a_b62d:
            ii(0x100a_b62d, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
            ii(0x100a_b631, 5); jmp(0x100a_ba67, 0x431); goto l_0x100a_ba67; /* jmp 0x100aba67 */
        l_0x100a_b636:
            ii(0x100a_b636, 7); mov(memd[ss, ebp - 20], 0);             /* mov dword [ebp-0x14], 0x0 */
            ii(0x100a_b63d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_b640, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x100a_b643, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_b648, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100a_b64e, 5); mov(edx, 0x101c_31c4);                  /* mov edx, 0x101c31c4 */
            ii(0x100a_b653, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_b655, 5); call(0x100b_a098, 0xea3e);              /* call 0x100ba098 */
            ii(0x100a_b65a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_b65c, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100a_b65f, 5); call(0x1008_a1a4, -0x2_14c0);           /* call 0x1008a1a4 */
            ii(0x100a_b664, 7); mov(memd[ss, ebp - 16], 0);             /* mov dword [ebp-0x10], 0x0 */
            ii(0x100a_b66b, 2); jmp(0x100a_b673, 6); goto l_0x100a_b673; /* jmp 0x100ab673 */
        l_0x100a_b66d:
            ii(0x100a_b66d, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100a_b670, 3); inc(memd[ss, ebp - 16]);                /* inc dword [ebp-0x10] */
        l_0x100a_b673:
            ii(0x100a_b673, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x100a_b677, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x100a_b67a, 6); if(jge(0x100a_b7fb, 0x17b)) goto l_0x100a_b7fb; /* jge 0x100ab7fb */
            ii(0x100a_b680, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x100a_b684, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_b68a, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100a_b690, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_b695, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_b697, 2); if(jnz(0x100a_b6a7, 0xe)) goto l_0x100a_b6a7; /* jnz 0x100ab6a7 */
            ii(0x100a_b699, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x100a_b69d, 5); mov(memb[ds, eax + ebp - 44], 0);       /* mov byte [eax+ebp-0x2c], 0x0 */
            ii(0x100a_b6a2, 5); jmp(0x100a_b7f6, 0x14f); goto l_0x100a_b7f6; /* jmp 0x100ab7f6 */
        l_0x100a_b6a7:
            ii(0x100a_b6a7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_b6aa, 5); cmp(memw[ds, eax + 8], 0x47);           /* cmp word [eax+0x8], 0x47 */
            ii(0x100a_b6af, 2); if(jz(0x100a_b6bb, 0xa)) goto l_0x100a_b6bb; /* jz 0x100ab6bb */
            ii(0x100a_b6b1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_b6b4, 5); cmp(memw[ds, eax + 8], 0x41);           /* cmp word [eax+0x8], 0x41 */
            ii(0x100a_b6b9, 2); if(jnz(0x100a_b6d8, 0x1d)) goto l_0x100a_b6d8; /* jnz 0x100ab6d8 */
        l_0x100a_b6bb:
            ii(0x100a_b6bb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_b6be, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x100a_b6c0, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_b6c3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_b6c6, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100a_b6c9, 5); call(0x1007_3d48, -0x3_7986);           /* call 0x10073d48 */
            ii(0x100a_b6ce, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x100a_b6d3, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x100a_b6d6, 2); if(jz(0x100a_b6da, 2)) goto l_0x100a_b6da; /* jz 0x100ab6da */
        l_0x100a_b6d8:
            ii(0x100a_b6d8, 2); jmp(0x100a_b6ea, 0x10); goto l_0x100a_b6ea; /* jmp 0x100ab6ea */
        l_0x100a_b6da:
            ii(0x100a_b6da, 4); movsx(edx, memw[ss, ebp - 16]);         /* movsx edx, word [ebp-0x10] */
            ii(0x100a_b6de, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_b6e1, 5); call(0x1007_6274, -0x3_5472);           /* call 0x10076274 */
            ii(0x100a_b6e6, 2); test(al, al);                           /* test al, al */
            ii(0x100a_b6e8, 2); if(jz(0x100a_b6ec, 2)) goto l_0x100a_b6ec; /* jz 0x100ab6ec */
        l_0x100a_b6ea:
            ii(0x100a_b6ea, 2); jmp(0x100a_b73e, 0x52); goto l_0x100a_b73e; /* jmp 0x100ab73e */
        l_0x100a_b6ec:
            ii(0x100a_b6ec, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_b6ef, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x100a_b6f1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_b6f4, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x100a_b6f9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_b6fc, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100a_b6ff, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_b702, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100a_b705, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100a_b707, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x100a_b70b, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_b711, 6); mov(eax, memd[ds, eax + 0x101c_a6a7]);  /* mov eax, [eax+0x101ca6a7] */
            ii(0x100a_b717, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_b719, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x100a_b71b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_b720, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_b722, 2); if(jz(0x100a_b72a, 6)) goto l_0x100a_b72a; /* jz 0x100ab72a */
            ii(0x100a_b724, 4); mov(memb[ss, ebp - 48], 1);             /* mov byte [ebp-0x30], 0x1 */
            ii(0x100a_b728, 2); jmp(0x100a_b72e, 4); goto l_0x100a_b72e; /* jmp 0x100ab72e */
        l_0x100a_b72a:
            ii(0x100a_b72a, 4); mov(memb[ss, ebp - 48], 0);             /* mov byte [ebp-0x30], 0x0 */
        l_0x100a_b72e:
            ii(0x100a_b72e, 4); movsx(edx, memw[ss, ebp - 16]);         /* movsx edx, word [ebp-0x10] */
            ii(0x100a_b732, 3); mov(al, memb[ss, ebp - 48]);            /* mov al, [ebp-0x30] */
            ii(0x100a_b735, 4); mov(memb[ds, edx + ebp - 44], al);      /* mov [edx+ebp-0x2c], al */
            ii(0x100a_b739, 5); jmp(0x100a_b7f6, 0xb8); goto l_0x100a_b7f6; /* jmp 0x100ab7f6 */
        l_0x100a_b73e:
            ii(0x100a_b73e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_b741, 5); cmp(memw[ds, eax + 8], 0x42);           /* cmp word [eax+0x8], 0x42 */
            ii(0x100a_b746, 2); if(jnz(0x100a_b758, 0x10)) goto l_0x100a_b758; /* jnz 0x100ab758 */
            ii(0x100a_b748, 4); movsx(edx, memw[ss, ebp - 16]);         /* movsx edx, word [ebp-0x10] */
            ii(0x100a_b74c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_b74f, 5); call(0x1007_6274, -0x3_54e0);           /* call 0x10076274 */
            ii(0x100a_b754, 2); test(al, al);                           /* test al, al */
            ii(0x100a_b756, 2); if(jz(0x100a_b75a, 2)) goto l_0x100a_b75a; /* jz 0x100ab75a */
        l_0x100a_b758:
            ii(0x100a_b758, 2); jmp(0x100a_b7a9, 0x4f); goto l_0x100a_b7a9; /* jmp 0x100ab7a9 */
        l_0x100a_b75a:
            ii(0x100a_b75a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_b75d, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x100a_b75f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_b762, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x100a_b767, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_b76a, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100a_b76d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_b770, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100a_b773, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100a_b775, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x100a_b779, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_b77f, 6); mov(eax, memd[ds, eax + 0x101c_a6ab]);  /* mov eax, [eax+0x101ca6ab] */
            ii(0x100a_b785, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_b787, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x100a_b789, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_b78e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_b790, 2); if(jz(0x100a_b798, 6)) goto l_0x100a_b798; /* jz 0x100ab798 */
            ii(0x100a_b792, 4); mov(memb[ss, ebp - 52], 1);             /* mov byte [ebp-0x34], 0x1 */
            ii(0x100a_b796, 2); jmp(0x100a_b79c, 4); goto l_0x100a_b79c; /* jmp 0x100ab79c */
        l_0x100a_b798:
            ii(0x100a_b798, 4); mov(memb[ss, ebp - 52], 0);             /* mov byte [ebp-0x34], 0x0 */
        l_0x100a_b79c:
            ii(0x100a_b79c, 4); movsx(edx, memw[ss, ebp - 16]);         /* movsx edx, word [ebp-0x10] */
            ii(0x100a_b7a0, 3); mov(al, memb[ss, ebp - 52]);            /* mov al, [ebp-0x34] */
            ii(0x100a_b7a3, 4); mov(memb[ds, edx + ebp - 44], al);      /* mov [edx+ebp-0x2c], al */
            ii(0x100a_b7a7, 2); jmp(0x100a_b7f6, 0x4d); goto l_0x100a_b7f6; /* jmp 0x100ab7f6 */
        l_0x100a_b7a9:
            ii(0x100a_b7a9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_b7ac, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x100a_b7ae, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_b7b1, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x100a_b7b6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_b7b9, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100a_b7bc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_b7bf, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100a_b7c2, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100a_b7c4, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x100a_b7c8, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_b7ce, 6); mov(eax, memd[ds, eax + 0x101c_a6a3]);  /* mov eax, [eax+0x101ca6a3] */
            ii(0x100a_b7d4, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_b7d6, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x100a_b7d8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_b7dd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_b7df, 2); if(jz(0x100a_b7e7, 6)) goto l_0x100a_b7e7; /* jz 0x100ab7e7 */
            ii(0x100a_b7e1, 4); mov(memb[ss, ebp - 56], 1);             /* mov byte [ebp-0x38], 0x1 */
            ii(0x100a_b7e5, 2); jmp(0x100a_b7eb, 4); goto l_0x100a_b7eb; /* jmp 0x100ab7eb */
        l_0x100a_b7e7:
            ii(0x100a_b7e7, 4); mov(memb[ss, ebp - 56], 0);             /* mov byte [ebp-0x38], 0x0 */
        l_0x100a_b7eb:
            ii(0x100a_b7eb, 4); movsx(edx, memw[ss, ebp - 16]);         /* movsx edx, word [ebp-0x10] */
            ii(0x100a_b7ef, 3); mov(al, memb[ss, ebp - 56]);            /* mov al, [ebp-0x38] */
            ii(0x100a_b7f2, 4); mov(memb[ds, edx + ebp - 44], al);      /* mov [edx+ebp-0x2c], al */
        l_0x100a_b7f6:
            ii(0x100a_b7f6, 5); jmp(0x100a_b66d, -0x18e); goto l_0x100a_b66d; /* jmp 0x100ab66d */
        l_0x100a_b7fb:
            ii(0x100a_b7fb, 7); mov(memd[ss, ebp - 16], 0);             /* mov dword [ebp-0x10], 0x0 */
        l_0x100a_b802:
            ii(0x100a_b802, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x100a_b806, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x100a_b809, 2); if(jge(0x100a_b82b, 0x20)) goto l_0x100a_b82b; /* jge 0x100ab82b */
            ii(0x100a_b80b, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x100a_b80f, 5); cmp(memb[ds, eax + ebp - 44], 0);       /* cmp byte [eax+ebp-0x2c], 0x0 */
            ii(0x100a_b814, 2); if(jz(0x100a_b829, 0x13)) goto l_0x100a_b829; /* jz 0x100ab829 */
            ii(0x100a_b816, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_b819, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x100a_b81c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_b821, 4); movsx(edx, memw[ss, ebp - 16]);         /* movsx edx, word [ebp-0x10] */
            ii(0x100a_b825, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_b827, 2); if(jnz(0x100a_b82b, 2)) goto l_0x100a_b82b; /* jnz 0x100ab82b */
        l_0x100a_b829:
            ii(0x100a_b829, 2); jmp(0x100a_b82d, 2); goto l_0x100a_b82d; /* jmp 0x100ab82d */
        l_0x100a_b82b:
            ii(0x100a_b82b, 2); jmp(0x100a_b835, 8); goto l_0x100a_b835; /* jmp 0x100ab835 */
        l_0x100a_b82d:
            ii(0x100a_b82d, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100a_b830, 3); inc(memd[ss, ebp - 16]);                /* inc dword [ebp-0x10] */
            ii(0x100a_b833, 2); jmp(0x100a_b802, -0x33); goto l_0x100a_b802; /* jmp 0x100ab802 */
        l_0x100a_b835:
            ii(0x100a_b835, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x100a_b839, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x100a_b83c, 2); if(jnz(0x100a_b851, 0x13)) goto l_0x100a_b851; /* jnz 0x100ab851 */
            ii(0x100a_b83e, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
            ii(0x100a_b842, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_b844, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100a_b847, 5); call(0x1008_8e4c, -0x2_2a00);           /* call 0x10088e4c */
            ii(0x100a_b84c, 5); jmp(0x100a_ba67, 0x216); goto l_0x100a_ba67; /* jmp 0x100aba67 */
        l_0x100a_b851:
            ii(0x100a_b851, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x100a_b856, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x100a_b85b, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_b85e, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x100a_b861, 5); call(0x1007_5e64, -0x3_5a02);           /* call 0x10075e64 */
            ii(0x100a_b866, 3); mov(esi, memd[ss, ebp - 8]);            /* mov esi, [ebp-0x8] */
            ii(0x100a_b869, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_b86b, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100a_b86d, 5); call(0x100a_90f9, -0x2779);             /* call 0x100a90f9 */
            ii(0x100a_b872, 2); test(al, al);                           /* test al, al */
            ii(0x100a_b874, 2); if(jnz(0x100a_b889, 0x13)) goto l_0x100a_b889; /* jnz 0x100ab889 */
            ii(0x100a_b876, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
            ii(0x100a_b87a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_b87c, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100a_b87f, 5); call(0x1008_8e4c, -0x2_2a38);           /* call 0x10088e4c */
            ii(0x100a_b884, 5); jmp(0x100a_ba67, 0x1de); goto l_0x100a_ba67; /* jmp 0x100aba67 */
        l_0x100a_b889:
            ii(0x100a_b889, 2); jmp(0x100a_b893, 8); goto l_0x100a_b893; /* jmp 0x100ab893 */
        l_0x100a_b88b:
            ii(0x100a_b88b, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100a_b88e, 5); call(0x1007_6bf8, -0x3_4c9b);           /* call 0x10076bf8 */
        l_0x100a_b893:
            ii(0x100a_b893, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_b895, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100a_b898, 5); call(0x1013_ad71, 0x8_f4d4);            /* call 0x1013ad71 */
            ii(0x100a_b89d, 2); test(al, al);                           /* test al, al */
            ii(0x100a_b89f, 6); if(jz(0x100a_ba35, 0x190)) goto l_0x100a_ba35; /* jz 0x100aba35 */
            ii(0x100a_b8a5, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100a_b8a8, 5); call(0x1008_a0f8, -0x2_17b5);           /* call 0x1008a0f8 */
            ii(0x100a_b8ad, 5); call(0x1008_a370, -0x2_1542);           /* call 0x1008a370 */
            ii(0x100a_b8b2, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x100a_b8b5, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x100a_b8b8, 5); call(0x1007_623c, -0x3_5681);           /* call 0x1007623c */
            ii(0x100a_b8bd, 4); mov(ax, memw[ds, eax + 18]);            /* mov ax, [eax+0x12] */
            ii(0x100a_b8c1, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x100a_b8c4, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x100a_b8c7, 3); mov(al, memb[ds, eax + 84]);            /* mov al, [eax+0x54] */
            ii(0x100a_b8ca, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_b8cf, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_b8d1, 2); if(jz(0x100a_b8e5, 0x12)) goto l_0x100a_b8e5; /* jz 0x100ab8e5 */
            ii(0x100a_b8d3, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x100a_b8d6, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x100a_b8d9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_b8de, 5); cmp(memb[ds, eax + ebp - 44], 0);       /* cmp byte [eax+ebp-0x2c], 0x0 */
            ii(0x100a_b8e3, 2); if(jnz(0x100a_b8e7, 2)) goto l_0x100a_b8e7; /* jnz 0x100ab8e7 */
        l_0x100a_b8e5:
            ii(0x100a_b8e5, 2); jmp(0x100a_b8f6, 0xf); goto l_0x100a_b8f6; /* jmp 0x100ab8f6 */
        l_0x100a_b8e7:
            ii(0x100a_b8e7, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x100a_b8ea, 3); mov(al, memb[ds, eax + 84]);            /* mov al, [eax+0x54] */
            ii(0x100a_b8ed, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_b8f2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_b8f4, 2); if(jg(0x100a_b8f8, 2)) goto l_0x100a_b8f8; /* jg 0x100ab8f8 */
        l_0x100a_b8f6:
            ii(0x100a_b8f6, 2); jmp(0x100a_b901, 9); goto l_0x100a_b901; /* jmp 0x100ab901 */
        l_0x100a_b8f8:
            ii(0x100a_b8f8, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x100a_b8fb, 4); cmp(ax, memw[ss, ebp - 20]);            /* cmp ax, [ebp-0x14] */
            ii(0x100a_b8ff, 2); if(jg(0x100a_b903, 2)) goto l_0x100a_b903; /* jg 0x100ab903 */
        l_0x100a_b901:
            ii(0x100a_b901, 2); jmp(0x100a_b92b, 0x28); goto l_0x100a_b92b; /* jmp 0x100ab92b */
        l_0x100a_b903:
            ii(0x100a_b903, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_b906, 3); lea(eax, memd[ss, ebp - 60]);           /* lea eax, [ebp-0x3c] */
            ii(0x100a_b909, 5); call(0x1007_5e64, -0x3_5aaa);           /* call 0x10075e64 */
            ii(0x100a_b90e, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100a_b910, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_b913, 3); mov(edx, memd[ds, eax + 6]);            /* mov edx, [eax+0x6] */
            ii(0x100a_b916, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_b919, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x100a_b91c, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100a_b91f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_b922, 5); call(0x1007_4a19, -0x3_6f0e);           /* call 0x10074a19 */
            ii(0x100a_b927, 2); test(al, al);                           /* test al, al */
            ii(0x100a_b929, 2); if(jnz(0x100a_b930, 5)) goto l_0x100a_b930; /* jnz 0x100ab930 */
        l_0x100a_b92b:
            ii(0x100a_b92b, 5); jmp(0x100a_ba30, 0x100); goto l_0x100a_ba30; /* jmp 0x100aba30 */
        l_0x100a_b930:
            ii(0x100a_b930, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x100a_b933, 5); call(0x1007_623c, -0x3_56fc);           /* call 0x1007623c */
            ii(0x100a_b938, 3); mov(memd[ss, ebp - 64], eax);           /* mov [ebp-0x40], eax */
            ii(0x100a_b93b, 3); lea(edx, memd[ss, ebp - 68]);           /* lea edx, [ebp-0x44] */
            ii(0x100a_b93e, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100a_b941, 5); call(0x1008_a0f8, -0x2_184e);           /* call 0x1008a0f8 */
            ii(0x100a_b946, 5); call(0x100b_8e63, 0xd518);              /* call 0x100b8e63 */
            ii(0x100a_b94b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_b94d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_b950, 5); call(0x1007_0ca1, -0x3_acb4);           /* call 0x10070ca1 */
            ii(0x100a_b955, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x100a_b958, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x100a_b95b, 3); mov(edx, memd[ss, ebp - 64]);           /* mov edx, [ebp-0x40] */
            ii(0x100a_b95e, 4); add(ax, memw[ds, edx + 29]);            /* add ax, [edx+0x1d] */
            ii(0x100a_b962, 3); mov(memd[ss, ebp - 72], eax);           /* mov [ebp-0x48], eax */
            ii(0x100a_b965, 3); mov(eax, memd[ss, ebp - 64]);           /* mov eax, [ebp-0x40] */
            ii(0x100a_b968, 4); cmp(memb[ds, eax + 22], 0);             /* cmp byte [eax+0x16], 0x0 */
            ii(0x100a_b96c, 2); if(jz(0x100a_b98b, 0x1d)) goto l_0x100a_b98b; /* jz 0x100ab98b */
            ii(0x100a_b96e, 3); mov(edx, memd[ss, ebp - 64]);           /* mov edx, [ebp-0x40] */
            ii(0x100a_b971, 3); mov(edx, memd[ds, edx + 14]);           /* mov edx, [edx+0xe] */
            ii(0x100a_b974, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_b977, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100a_b979, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100a_b97c, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100a_b97e, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x100a_b980, 4); movsx(edx, memw[ss, ebp - 72]);         /* movsx edx, word [ebp-0x48] */
            ii(0x100a_b984, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100a_b986, 3); mov(memd[ss, ebp - 72], edx);           /* mov [ebp-0x48], edx */
            ii(0x100a_b989, 2); jmp(0x100a_b9bd, 0x32); goto l_0x100a_b9bd; /* jmp 0x100ab9bd */
        l_0x100a_b98b:
            ii(0x100a_b98b, 3); mov(edx, memd[ss, ebp - 64]);           /* mov edx, [ebp-0x40] */
            ii(0x100a_b98e, 3); mov(ebx, memd[ds, edx + 18]);           /* mov ebx, [edx+0x12] */
            ii(0x100a_b991, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_b994, 3); mov(edx, memd[ss, ebp - 64]);           /* mov edx, [ebp-0x40] */
            ii(0x100a_b997, 3); mov(eax, memd[ds, edx + 14]);           /* mov eax, [edx+0xe] */
            ii(0x100a_b99a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_b99d, 1); inc(eax);                               /* inc eax */
            ii(0x100a_b99e, 3); lea(edx, memd[ds, ebx - 1]);            /* lea edx, [ebx-0x1] */
            ii(0x100a_b9a1, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100a_b9a4, 3); mov(eax, memd[ss, ebp - 64]);           /* mov eax, [ebp-0x40] */
            ii(0x100a_b9a7, 3); mov(ebx, memd[ds, eax + 18]);           /* mov ebx, [eax+0x12] */
            ii(0x100a_b9aa, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_b9ad, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100a_b9af, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100a_b9b2, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100a_b9b4, 4); movsx(edx, memw[ss, ebp - 72]);         /* movsx edx, word [ebp-0x48] */
            ii(0x100a_b9b8, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100a_b9ba, 3); mov(memd[ss, ebp - 72], edx);           /* mov [ebp-0x48], edx */
        l_0x100a_b9bd:
            ii(0x100a_b9bd, 4); movsx(edx, memw[ss, ebp - 72]);         /* movsx edx, word [ebp-0x48] */
            ii(0x100a_b9c1, 4); movsx(eax, memw[ss, ebp - 72]);         /* movsx eax, word [ebp-0x48] */
            ii(0x100a_b9c5, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100a_b9c8, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x100a_b9cc, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_b9ce, 2); if(jg(0x100a_ba30, 0x60)) goto l_0x100a_ba30; /* jg 0x100aba30 */
            ii(0x100a_b9d0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_b9d3, 5); call(0x1007_623c, -0x3_579c);           /* call 0x1007623c */
            ii(0x100a_b9d8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_b9da, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x100a_b9dd, 4); cmp(ax, memw[ds, edx + 18]);            /* cmp ax, [edx+0x12] */
            ii(0x100a_b9e1, 2); if(jle(0x100a_b9f6, 0x13)) goto l_0x100a_b9f6; /* jle 0x100ab9f6 */
            ii(0x100a_b9e3, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
            ii(0x100a_b9e7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_b9e9, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100a_b9ec, 5); call(0x1008_8e4c, -0x2_2ba5);           /* call 0x10088e4c */
            ii(0x100a_b9f1, 5); jmp(0x100a_ba67, 0x71); goto l_0x100a_ba67; /* jmp 0x100aba67 */
        l_0x100a_b9f6:
            ii(0x100a_b9f6, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x100a_b9f9, 3); mov(edx, memd[ds, eax + 6]);            /* mov edx, [eax+0x6] */
            ii(0x100a_b9fc, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_b9ff, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_ba02, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100a_ba05, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_ba08, 5); call(0x1007_49d4, -0x3_7039);           /* call 0x100749d4 */
            ii(0x100a_ba0d, 2); test(al, al);                           /* test al, al */
            ii(0x100a_ba0f, 2); if(jnz(0x100a_ba21, 0x10)) goto l_0x100a_ba21; /* jnz 0x100aba21 */
            ii(0x100a_ba11, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
            ii(0x100a_ba15, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_ba17, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100a_ba1a, 5); call(0x1008_8e4c, -0x2_2bd3);           /* call 0x10088e4c */
            ii(0x100a_ba1f, 2); jmp(0x100a_ba67, 0x46); goto l_0x100a_ba67; /* jmp 0x100aba67 */
        l_0x100a_ba21:
            ii(0x100a_ba21, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_ba24, 5); call(0x1007_623c, -0x3_57ed);           /* call 0x1007623c */
            ii(0x100a_ba29, 4); mov(ax, memw[ds, eax + 18]);            /* mov ax, [eax+0x12] */
            ii(0x100a_ba2d, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
        l_0x100a_ba30:
            ii(0x100a_ba30, 5); jmp(0x100a_b88b, -0x1aa); goto l_0x100a_b88b; /* jmp 0x100ab88b */
        l_0x100a_ba35:
            ii(0x100a_ba35, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x100a_ba39, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_ba3b, 2); if(jnz(0x100a_ba4d, 0x10)) goto l_0x100a_ba4d; /* jnz 0x100aba4d */
            ii(0x100a_ba3d, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
            ii(0x100a_ba41, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_ba43, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100a_ba46, 5); call(0x1008_8e4c, -0x2_2bff);           /* call 0x10088e4c */
            ii(0x100a_ba4b, 2); jmp(0x100a_ba67, 0x1a); goto l_0x100a_ba67; /* jmp 0x100aba67 */
        l_0x100a_ba4d:
            ii(0x100a_ba4d, 4); mov(memb[ss, ebp - 12], 1);             /* mov byte [ebp-0xc], 0x1 */
            ii(0x100a_ba51, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_ba53, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100a_ba56, 5); call(0x1008_8e4c, -0x2_2c0f);           /* call 0x10088e4c */
            ii(0x100a_ba5b, 2); jmp(0x100a_ba67, 0xa); goto l_0x100a_ba67; /* jmp 0x100aba67 */
        //  ii(0x100a_ba5d, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100a_ba5f, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
        //  ii(0x100a_ba62, 5); call(0x1008_8e4c, -0x2_2c1b);           /* call 0x10088e4c */
        l_0x100a_ba67:
            ii(0x100a_ba67, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x100a_ba6a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_ba6c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_ba6d, 1); pop(edi);                               /* pop edi */
            ii(0x100a_ba6e, 1); pop(esi);                               /* pop esi */
            ii(0x100a_ba6f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_ba70, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_ba71, 1); ret();                                  /* ret */
        }
    }
}
