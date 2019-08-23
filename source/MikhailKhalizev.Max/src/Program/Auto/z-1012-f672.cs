using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_f672-c7591615")]
        public void Method_1012_f672()
        {
            ii(0x1012_f672, 5); push(0xb4);                             /* push 0xb4 */
            ii(0x1012_f677, 5); call(Definitions.sys_check_available_stack_size, 0x3_66d6); /* call 0x10165d52 */
            ii(0x1012_f67c, 1); push(ebx);                              /* push ebx */
            ii(0x1012_f67d, 1); push(ecx);                              /* push ecx */
            ii(0x1012_f67e, 1); push(edx);                              /* push edx */
            ii(0x1012_f67f, 1); push(esi);                              /* push esi */
            ii(0x1012_f680, 1); push(edi);                              /* push edi */
            ii(0x1012_f681, 1); push(ebp);                              /* push ebp */
            ii(0x1012_f682, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_f684, 6); sub(esp, 0x80);                         /* sub esp, 0x80 */
            ii(0x1012_f68a, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_f68d, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1012_f692, 5); call(/* sys */ 0x1016_a24c, 0x3_abb5);  /* call 0x1016a24c */
            ii(0x1012_f697, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f69a, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1012_f6a0, 5); call(0x100d_4ef0, -0x5_a7b5);           /* call 0x100d4ef0 */
            ii(0x1012_f6a5, 5); add(eax, 0x5);                          /* add eax, 0x5 */
            ii(0x1012_f6aa, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_f6ad, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f6b0, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1012_f6b6, 5); call(0x100d_4ebc, -0x5_a7ff);           /* call 0x100d4ebc */
            ii(0x1012_f6bb, 5); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1012_f6c0, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1012_f6c3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f6c6, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1012_f6c9, 5); call(Definitions.my_1_get_count, -0x8_41f6); /* call 0x100ab4d8 */
            ii(0x1012_f6ce, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_f6d1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f6d4, 3); mov(ebx, memd[ds, eax + 0x3c]);         /* mov ebx, [eax+0x3c] */
            ii(0x1012_f6d7, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_f6da, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f6dd, 3); mov(eax, memd[ds, eax + 0x32]);         /* mov eax, [eax+0x32] */
            ii(0x1012_f6e0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_f6e3, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1012_f6e5, 5); call(Definitions.my_min, -0xa_5f66);    /* call 0x10089784 */
            ii(0x1012_f6ea, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_f6ed, 3); lea(edx, memd[ss, ebp - 0x38]);         /* lea edx, [ebp-0x38] */
            ii(0x1012_f6f0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f6f3, 5); call(0x100d_6a11, -0x5_8ce7);           /* call 0x100d6a11 */
            ii(0x1012_f6f8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f6fb, 3); mov(eax, memd[ds, eax + 0x32]);         /* mov eax, [eax+0x32] */
            ii(0x1012_f6fe, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_f701, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_f703, 2); if(jnz(0x1012_f70e, 0x9)) goto l_0x1012_f70e; /* jnz 0x1012f70e */
            ii(0x1012_f705, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x1012_f70c, 2); jmp(0x1012_f72c, 0x1e); goto l_0x1012_f72c; /* jmp 0x1012f72c */
        l_0x1012_f70e:
            ii(0x1012_f70e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f711, 4); mov(ax, memw[ds, eax + 0x34]);          /* mov ax, [eax+0x34] */
            ii(0x1012_f715, 1); dec(eax);                               /* dec eax */
            ii(0x1012_f716, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_f719, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f71c, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1012_f71f, 5); call(0x1013_18f8, 0x21d4);              /* call 0x101318f8 */
            ii(0x1012_f724, 5); call(0x1013_19f4, 0x22cb);              /* call 0x101319f4 */
            ii(0x1012_f729, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
        l_0x1012_f72c:
            ii(0x1012_f72c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f72f, 4); mov(ax, memw[ds, eax + 0x34]);          /* mov ax, [eax+0x34] */
            ii(0x1012_f733, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1012_f736, 2); jmp(0x1012_f73e, 0x6); goto l_0x1012_f73e; /* jmp 0x1012f73e */
        l_0x1012_f738:
            ii(0x1012_f738, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_f73b, 3); inc(memd[ss, ebp - 0x14]);              /* inc dword [ebp-0x14] */
        l_0x1012_f73e:
            ii(0x1012_f73e, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_f741, 4); cmp(ax, memw[ss, ebp - 0x8]);           /* cmp ax, [ebp-0x8] */
            ii(0x1012_f745, 6); if(jge(0x1012_f976, 0x22b)) goto l_0x1012_f976; /* jge 0x1012f976 */
            ii(0x1012_f74b, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1012_f74f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f752, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1012_f755, 5); call(0x1013_18f8, 0x219e);              /* call 0x101318f8 */
            ii(0x1012_f75a, 5); call(0x1013_19f4, 0x2295);              /* call 0x101319f4 */
            ii(0x1012_f75f, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1012_f762, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1012_f765, 3); add(ebx, 0x36);                         /* add ebx, 0x36 */
            ii(0x1012_f768, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1012_f76c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f76f, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1012_f772, 5); call(0x1013_18f8, 0x2181);              /* call 0x101318f8 */
            ii(0x1012_f777, 5); call(0x1013_19f4, 0x2278);              /* call 0x101319f4 */
            ii(0x1012_f77c, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1012_f77e, 5); call(0x1007_6d98, -0xb_89eb);           /* call 0x10076d98 */
            ii(0x1012_f783, 2); test(al, al);                           /* test al, al */
            ii(0x1012_f785, 2); if(jz(0x1012_f78d, 0x6)) goto l_0x1012_f78d; /* jz 0x1012f78d */
            ii(0x1012_f787, 4); mov(memb[ss, ebp - 0x3c], 0x2);         /* mov byte [ebp-0x3c], 0x2 */
            ii(0x1012_f78b, 2); jmp(0x1012_f791, 0x4); goto l_0x1012_f791; /* jmp 0x1012f791 */
        l_0x1012_f78d:
            ii(0x1012_f78d, 4); mov(memb[ss, ebp - 0x3c], 0xa2);        /* mov byte [ebp-0x3c], 0xa2 */
        l_0x1012_f791:
            ii(0x1012_f791, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_f793, 3); mov(al, memb[ss, ebp - 0x3c]);          /* mov al, [ebp-0x3c] */
            ii(0x1012_f796, 1); push(eax);                              /* push eax */
            ii(0x1012_f797, 4); movsx(ecx, memw[ss, ebp - 0x28]);       /* movsx ecx, word [ebp-0x28] */
            ii(0x1012_f79b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f79e, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1012_f7a4, 5); call(0x100d_4f58, -0x5_a851);           /* call 0x100d4f58 */
            ii(0x1012_f7a9, 1); cwde();                                 /* cwde */
            ii(0x1012_f7aa, 3); lea(ebx, memd[ds, eax - 0x5f]);         /* lea ebx, [eax-0x5f] */
            ii(0x1012_f7ad, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1012_f7b1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f7b4, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1012_f7b7, 5); call(0x1013_18f8, 0x213c);              /* call 0x101318f8 */
            ii(0x1012_f7bc, 5); call(0x1013_1a2c, 0x226b);              /* call 0x10131a2c */
            ii(0x1012_f7c1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_f7c3, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1012_f7c7, 3); mov(esi, memd[ss, ebp - 0x22]);         /* mov esi, [ebp-0x22] */
            ii(0x1012_f7ca, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1012_f7cc, 3); mov(memd[ss, ebp - 0x40], esi);         /* mov [ebp-0x40], esi */
            ii(0x1012_f7cf, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1012_f7d3, 4); movsx(esi, memw[ss, ebp - 0xc]);        /* movsx esi, word [ebp-0xc] */
            ii(0x1012_f7d7, 3); imul(eax, esi);                         /* imul eax, esi */
            ii(0x1012_f7da, 3); mov(esi, memd[ss, ebp - 0x40]);         /* mov esi, [ebp-0x40] */
            ii(0x1012_f7dd, 3); add(esi, 0x55);                         /* add esi, 0x55 */
            ii(0x1012_f7e0, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1012_f7e2, 6); call_abs(memd[ds, 0x101b_ddec]);        /* call dword [0x101bddec] */
            ii(0x1012_f7e8, 4); cmp(memd[ss, ebp - 0x1c], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1012_f7ec, 2); if(jz(0x1012_f7f6, 0x8)) goto l_0x1012_f7f6; /* jz 0x1012f7f6 */
            ii(0x1012_f7ee, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1012_f7f1, 3); cmp(eax, memd[ss, ebp - 0x18]);         /* cmp eax, [ebp-0x18] */
            ii(0x1012_f7f4, 2); if(jnz(0x1012_f7f8, 0x2)) goto l_0x1012_f7f8; /* jnz 0x1012f7f8 */
        l_0x1012_f7f6:
            ii(0x1012_f7f6, 2); jmp(0x1012_f825, 0x2d); goto l_0x1012_f825; /* jmp 0x1012f825 */
        l_0x1012_f7f8:
            ii(0x1012_f7f8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f7fb, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1012_f801, 5); call(0x100d_4ebc, -0x5_a94a);           /* call 0x100d4ebc */
            ii(0x1012_f806, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_f809, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f80c, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1012_f812, 5); call(0x100d_4f24, -0x5_a8f3);           /* call 0x100d4f24 */
            ii(0x1012_f817, 1); cwde();                                 /* cwde */
            ii(0x1012_f818, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_f81a, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1012_f81e, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1012_f820, 3); cmp(edx, 0x26);                         /* cmp edx, 0x26 */
            ii(0x1012_f823, 2); if(jge(0x1012_f82a, 0x5)) goto l_0x1012_f82a; /* jge 0x1012f82a */
        l_0x1012_f825:
            ii(0x1012_f825, 5); jmp(0x1012_f962, 0x138); goto l_0x1012_f962; /* jmp 0x1012f962 */
        l_0x1012_f82a:
            ii(0x1012_f82a, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1012_f82d, 5); call(0x1013_1a64, 0x2232);              /* call 0x10131a64 */
            ii(0x1012_f832, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_f834, 6); if(jz(0x1012_f90f, 0xd5)) goto l_0x1012_f90f; /* jz 0x1012f90f */
            ii(0x1012_f83a, 3); lea(edx, memd[ss, ebp - 0x44]);         /* lea edx, [ebp-0x44] */
            ii(0x1012_f83d, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1012_f840, 5); call(0x1013_1a9c, 0x2257);              /* call 0x10131a9c */
            ii(0x1012_f845, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1012_f848, 5); call(0x1013_1a64, 0x2217);              /* call 0x10131a64 */
            ii(0x1012_f84d, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x1012_f850, 5); call(0x100d_531c, -0x5_a539);           /* call 0x100d531c */
            ii(0x1012_f855, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_f85a, 1); push(eax);                              /* push eax */
            ii(0x1012_f85b, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_f860, 1); push(eax);                              /* push eax */
            ii(0x1012_f861, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1012_f864, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1012_f867, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_f86c, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1012_f86f, 6); push(memd[ds, eax + 0x101b_b4a0]);      /* push dword [eax+0x101bb4a0] */
            ii(0x1012_f875, 5); mov(eax, 0x20);                         /* mov eax, 0x20 */
            ii(0x1012_f87a, 1); push(eax);                              /* push eax */
            ii(0x1012_f87b, 5); mov(eax, 0x28);                         /* mov eax, 0x28 */
            ii(0x1012_f880, 1); push(eax);                              /* push eax */
            ii(0x1012_f881, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1012_f885, 1); push(eax);                              /* push eax */
            ii(0x1012_f886, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_f889, 5); add(eax, 0x28);                         /* add eax, 0x28 */
            ii(0x1012_f88e, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1012_f891, 4); movsx(eax, memw[ss, ebp - 0x42]);       /* movsx eax, word [ebp-0x42] */
            ii(0x1012_f895, 1); inc(eax);                               /* inc eax */
            ii(0x1012_f896, 1); push(eax);                              /* push eax */
            ii(0x1012_f897, 4); movsx(eax, memw[ss, ebp - 0x44]);       /* movsx eax, word [ebp-0x44] */
            ii(0x1012_f89b, 1); inc(eax);                               /* inc eax */
            ii(0x1012_f89c, 1); push(eax);                              /* push eax */
            ii(0x1012_f89d, 5); mov(eax, StringDefinitions.II4);        /* mov eax, 0x101a87ee */
            ii(0x1012_f8a2, 1); push(eax);                              /* push eax */
            ii(0x1012_f8a3, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1012_f8a8, 1); push(eax);                              /* push eax */
            ii(0x1012_f8a9, 3); lea(eax, memd[ss, ebp - 0x4c]);         /* lea eax, [ebp-0x4c] */
            ii(0x1012_f8ac, 5); call(Definitions.my_string_ctor, 0x1_2237); /* call 0x10141ae8 */
            ii(0x1012_f8b1, 1); push(eax);                              /* push eax */
            ii(0x1012_f8b2, 5); call(0x1014_2037, 0x1_2780);            /* call 0x10142037 */
            ii(0x1012_f8b7, 3); add(esp, 0x14);                         /* add esp, 0x14 */
            ii(0x1012_f8ba, 5); call(Definitions.my_strobj_c_str_v2, -0xa_60f7); /* call 0x100897c8 */
            ii(0x1012_f8bf, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1012_f8c3, 3); mov(esi, memd[ss, ebp - 0x22]);         /* mov esi, [ebp-0x22] */
            ii(0x1012_f8c6, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1012_f8c8, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1012_f8ca, 5); call(0x100e_9ae5, -0x4_5dea);           /* call 0x100e9ae5 */
            ii(0x1012_f8cf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_f8d1, 3); lea(eax, memd[ss, ebp - 0x4c]);         /* lea eax, [ebp-0x4c] */
            ii(0x1012_f8d4, 5); call(Definitions.my_string_dtor, 0x1_2251); /* call 0x10141b2a */
            ii(0x1012_f8d9, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_f8dc, 5); add(eax, 0x10);                         /* add eax, 0x10 */
            ii(0x1012_f8e1, 1); cwde();                                 /* cwde */
            ii(0x1012_f8e2, 1); push(eax);                              /* push eax */
            ii(0x1012_f8e3, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_f8e6, 5); add(eax, 0x10);                         /* add eax, 0x10 */
            ii(0x1012_f8eb, 1); cwde();                                 /* cwde */
            ii(0x1012_f8ec, 1); push(eax);                              /* push eax */
            ii(0x1012_f8ed, 3); mov(edx, memd[ss, ebp - 0x48]);         /* mov edx, [ebp-0x48] */
            ii(0x1012_f8f0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_f8f2, 3); mov(al, memb[ds, edx + 0x26]);          /* mov al, [edx+0x26] */
            ii(0x1012_f8f5, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1012_f8f8, 3); mov(ebx, memd[ss, ebp - 0x48]);         /* mov ebx, [ebp-0x48] */
            ii(0x1012_f8fb, 3); mov(ebx, memd[ds, ebx + 0x6]);          /* mov ebx, [ebx+0x6] */
            ii(0x1012_f8fe, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_f901, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1012_f905, 3); mov(eax, memd[ss, ebp - 0x22]);         /* mov eax, [ebp-0x22] */
            ii(0x1012_f908, 5); call(0x1012_b6af, -0x425e);             /* call 0x1012b6af */
            ii(0x1012_f90d, 2); jmp(0x1012_f962, 0x53); goto l_0x1012_f962; /* jmp 0x1012f962 */
        l_0x1012_f90f:
            ii(0x1012_f90f, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1012_f912, 5); call(0x1013_1b04, 0x21ed);              /* call 0x10131b04 */
            ii(0x1012_f917, 4); cmp(ax, 0xffff);                        /* cmp ax, 0xffff */
            ii(0x1012_f91b, 2); if(jz(0x1012_f962, 0x45)) goto l_0x1012_f962; /* jz 0x1012f962 */
            ii(0x1012_f91d, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1012_f920, 5); call(0x1013_1b04, 0x21df);              /* call 0x10131b04 */
            ii(0x1012_f925, 1); cwde();                                 /* cwde */
            ii(0x1012_f926, 5); call(Definitions.my_get_res_data_by_id, 0x46ad); /* call 0x10133fd8 */
            ii(0x1012_f92b, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x1012_f92e, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x1012_f931, 1); push(eax);                              /* push eax */
            ii(0x1012_f932, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1012_f937, 3); mov(edx, memd[ss, ebp - 0x50]);         /* mov edx, [ebp-0x50] */
            ii(0x1012_f93a, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x1012_f93c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_f93f, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_f941, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_f944, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1012_f946, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1012_f948, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1012_f94c, 3); add(edx, 0x10);                         /* add edx, 0x10 */
            ii(0x1012_f94f, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1012_f951, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_f953, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1012_f956, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1012_f95a, 3); mov(eax, memd[ss, ebp - 0x50]);         /* mov eax, [ebp-0x50] */
            ii(0x1012_f95d, 5); call(0x100e_8d1e, -0x4_6c44);           /* call 0x100e8d1e */
        l_0x1012_f962:
            ii(0x1012_f962, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1012_f965, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1012_f968, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x1012_f96e, 3); add(memd[ss, ebp - 0xc], eax);          /* add [ebp-0xc], eax */
            ii(0x1012_f971, 5); jmp(0x1012_f738, -0x23e); goto l_0x1012_f738; /* jmp 0x1012f738 */
        l_0x1012_f976:
            ii(0x1012_f976, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_f978, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f97b, 3); add(eax, 0x36);                         /* add eax, 0x36 */
            ii(0x1012_f97e, 5); call(0x1013_ad71, 0xb3ee);              /* call 0x1013ad71 */
            ii(0x1012_f983, 2); test(al, al);                           /* test al, al */
            ii(0x1012_f985, 6); if(jz(0x1012_fb39, 0x1ae)) goto l_0x1012_fb39; /* jz 0x1012fb39 */
            ii(0x1012_f98b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f98e, 3); add(eax, 0x36);                         /* add eax, 0x36 */
            ii(0x1012_f991, 5); call(0x1013_1c0c, 0x2276);              /* call 0x10131c0c */
            ii(0x1012_f996, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_f998, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f99b, 5); call(0x1012_e2a7, -0x16f9);             /* call 0x1012e2a7 */
            ii(0x1012_f9a0, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1012_f9a3, 4); sub(ax, memw[ds, edx + 0x34]);          /* sub ax, [edx+0x34] */
            ii(0x1012_f9a7, 3); mov(memd[ss, ebp - 0x54], eax);         /* mov [ebp-0x54], eax */
            ii(0x1012_f9aa, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f9ad, 3); add(eax, 0x36);                         /* add eax, 0x36 */
            ii(0x1012_f9b0, 5); call(0x1013_1c0c, 0x2257);              /* call 0x10131c0c */
            ii(0x1012_f9b5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_f9b7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f9ba, 5); call(0x1012_e30e, -0x16b1);             /* call 0x1012e30e */
            ii(0x1012_f9bf, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1012_f9c2, 4); sub(ax, memw[ds, edx + 0x34]);          /* sub ax, [edx+0x34] */
            ii(0x1012_f9c6, 3); mov(memd[ss, ebp - 0x58], eax);         /* mov [ebp-0x58], eax */
            ii(0x1012_f9c9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f9cc, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1012_f9d2, 5); call(0x100d_4ebc, -0x5_ab1b);           /* call 0x100d4ebc */
            ii(0x1012_f9d7, 3); mov(memd[ss, ebp - 0x5c], eax);         /* mov [ebp-0x5c], eax */
            ii(0x1012_f9da, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f9dd, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1012_f9e3, 5); call(0x100d_4ebc, -0x5_ab2c);           /* call 0x100d4ebc */
            ii(0x1012_f9e8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_f9ea, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_f9ed, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1012_f9f3, 5); call(0x100d_4f24, -0x5_aad4);           /* call 0x100d4f24 */
            ii(0x1012_f9f8, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_f9fa, 3); mov(memd[ss, ebp - 0x60], edx);         /* mov [ebp-0x60], edx */
            ii(0x1012_f9fd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_fa00, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1012_fa06, 5); call(0x100d_4ef0, -0x5_ab1b);           /* call 0x100d4ef0 */
            ii(0x1012_fa0b, 1); cwde();                                 /* cwde */
            ii(0x1012_fa0c, 3); mov(memd[ss, ebp - 0x70], eax);         /* mov [ebp-0x70], eax */
            ii(0x1012_fa0f, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x1012_fa15, 4); movsx(edx, memw[ss, ebp - 0x54]);       /* movsx edx, word [ebp-0x54] */
            ii(0x1012_fa19, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1012_fa1c, 4); movsx(edx, memw[ss, ebp - 0x5c]);       /* movsx edx, word [ebp-0x5c] */
            ii(0x1012_fa20, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_fa22, 3); add(eax, 0x3);                          /* add eax, 0x3 */
            ii(0x1012_fa25, 3); mov(memd[ss, ebp - 0x6c], eax);         /* mov [ebp-0x6c], eax */
            ii(0x1012_fa28, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_fa2b, 6); mov(eax, memd[ds, eax + 0xde]);         /* mov eax, [eax+0xde] */
            ii(0x1012_fa31, 5); call(0x100d_4f58, -0x5_aade);           /* call 0x100d4f58 */
            ii(0x1012_fa36, 1); cwde();                                 /* cwde */
            ii(0x1012_fa37, 3); add(eax, memd[ss, ebp - 0x70]);         /* add eax, [ebp-0x70] */
            ii(0x1012_fa3a, 1); dec(eax);                               /* dec eax */
            ii(0x1012_fa3b, 3); mov(memd[ss, ebp - 0x68], eax);         /* mov [ebp-0x68], eax */
            ii(0x1012_fa3e, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x1012_fa44, 4); movsx(edx, memw[ss, ebp - 0x58]);       /* movsx edx, word [ebp-0x58] */
            ii(0x1012_fa48, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1012_fa4b, 4); movsx(edx, memw[ss, ebp - 0x5c]);       /* movsx edx, word [ebp-0x5c] */
            ii(0x1012_fa4f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_fa51, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1012_fa54, 3); mov(memd[ss, ebp - 0x64], eax);         /* mov [ebp-0x64], eax */
            ii(0x1012_fa57, 4); movsx(eax, memw[ss, ebp - 0x5c]);       /* movsx eax, word [ebp-0x5c] */
            ii(0x1012_fa5b, 3); cmp(eax, memd[ss, ebp - 0x6c]);         /* cmp eax, [ebp-0x6c] */
            ii(0x1012_fa5e, 2); if(jg(0x1012_fa69, 0x9)) goto l_0x1012_fa69; /* jg 0x1012fa69 */
            ii(0x1012_fa60, 4); movsx(eax, memw[ss, ebp - 0x60]);       /* movsx eax, word [ebp-0x60] */
            ii(0x1012_fa64, 3); cmp(eax, memd[ss, ebp - 0x6c]);         /* cmp eax, [ebp-0x6c] */
            ii(0x1012_fa67, 2); if(jg(0x1012_fa6b, 0x2)) goto l_0x1012_fa6b; /* jg 0x1012fa6b */
        l_0x1012_fa69:
            ii(0x1012_fa69, 2); jmp(0x1012_fa8a, 0x1f); goto l_0x1012_fa8a; /* jmp 0x1012fa8a */
        l_0x1012_fa6b:
            ii(0x1012_fa6b, 5); push(0xa2);                             /* push 0xa2 */
            ii(0x1012_fa70, 3); mov(eax, memd[ss, ebp - 0x6c]);         /* mov eax, [ebp-0x6c] */
            ii(0x1012_fa73, 1); push(eax);                              /* push eax */
            ii(0x1012_fa74, 3); mov(eax, memd[ss, ebp - 0x68]);         /* mov eax, [ebp-0x68] */
            ii(0x1012_fa77, 1); push(eax);                              /* push eax */
            ii(0x1012_fa78, 3); mov(ecx, memd[ss, ebp - 0x6c]);         /* mov ecx, [ebp-0x6c] */
            ii(0x1012_fa7b, 3); mov(ebx, memd[ss, ebp - 0x70]);         /* mov ebx, [ebp-0x70] */
            ii(0x1012_fa7e, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1012_fa82, 3); mov(eax, memd[ss, ebp - 0x22]);         /* mov eax, [ebp-0x22] */
            ii(0x1012_fa85, 5); call(/* sys */ 0x1016_a5a0, 0x3_ab16);  /* call 0x1016a5a0 */
        l_0x1012_fa8a:
            ii(0x1012_fa8a, 4); movsx(eax, memw[ss, ebp - 0x5c]);       /* movsx eax, word [ebp-0x5c] */
            ii(0x1012_fa8e, 3); cmp(eax, memd[ss, ebp - 0x64]);         /* cmp eax, [ebp-0x64] */
            ii(0x1012_fa91, 2); if(jg(0x1012_fa9c, 0x9)) goto l_0x1012_fa9c; /* jg 0x1012fa9c */
            ii(0x1012_fa93, 4); movsx(eax, memw[ss, ebp - 0x60]);       /* movsx eax, word [ebp-0x60] */
            ii(0x1012_fa97, 3); cmp(eax, memd[ss, ebp - 0x6c]);         /* cmp eax, [ebp-0x6c] */
            ii(0x1012_fa9a, 2); if(jg(0x1012_fa9e, 0x2)) goto l_0x1012_fa9e; /* jg 0x1012fa9e */
        l_0x1012_fa9c:
            ii(0x1012_fa9c, 2); jmp(0x1012_fabd, 0x1f); goto l_0x1012_fabd; /* jmp 0x1012fabd */
        l_0x1012_fa9e:
            ii(0x1012_fa9e, 5); push(0xa2);                             /* push 0xa2 */
            ii(0x1012_faa3, 3); mov(eax, memd[ss, ebp - 0x64]);         /* mov eax, [ebp-0x64] */
            ii(0x1012_faa6, 1); push(eax);                              /* push eax */
            ii(0x1012_faa7, 3); mov(eax, memd[ss, ebp - 0x68]);         /* mov eax, [ebp-0x68] */
            ii(0x1012_faaa, 1); push(eax);                              /* push eax */
            ii(0x1012_faab, 3); mov(ecx, memd[ss, ebp - 0x64]);         /* mov ecx, [ebp-0x64] */
            ii(0x1012_faae, 3); mov(ebx, memd[ss, ebp - 0x70]);         /* mov ebx, [ebp-0x70] */
            ii(0x1012_fab1, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1012_fab5, 3); mov(eax, memd[ss, ebp - 0x22]);         /* mov eax, [ebp-0x22] */
            ii(0x1012_fab8, 5); call(/* sys */ 0x1016_a5a0, 0x3_aae3);  /* call 0x1016a5a0 */
        l_0x1012_fabd:
            ii(0x1012_fabd, 4); movsx(eax, memw[ss, ebp - 0x60]);       /* movsx eax, word [ebp-0x60] */
            ii(0x1012_fac1, 3); cmp(eax, memd[ss, ebp - 0x6c]);         /* cmp eax, [ebp-0x6c] */
            ii(0x1012_fac4, 2); if(jle(0x1012_facf, 0x9)) goto l_0x1012_facf; /* jle 0x1012facf */
            ii(0x1012_fac6, 4); movsx(eax, memw[ss, ebp - 0x5c]);       /* movsx eax, word [ebp-0x5c] */
            ii(0x1012_faca, 3); cmp(eax, memd[ss, ebp - 0x64]);         /* cmp eax, [ebp-0x64] */
            ii(0x1012_facd, 2); if(jle(0x1012_fad1, 0x2)) goto l_0x1012_fad1; /* jle 0x1012fad1 */
        l_0x1012_facf:
            ii(0x1012_facf, 2); jmp(0x1012_fb39, 0x68); goto l_0x1012_fb39; /* jmp 0x1012fb39 */
        l_0x1012_fad1:
            ii(0x1012_fad1, 5); push(0xa2);                             /* push 0xa2 */
            ii(0x1012_fad6, 4); movsx(edx, memw[ss, ebp - 0x60]);       /* movsx edx, word [ebp-0x60] */
            ii(0x1012_fada, 3); mov(eax, memd[ss, ebp - 0x64]);         /* mov eax, [ebp-0x64] */
            ii(0x1012_fadd, 5); call(Definitions.my_min, -0xa_635e);    /* call 0x10089784 */
            ii(0x1012_fae2, 1); push(eax);                              /* push eax */
            ii(0x1012_fae3, 3); mov(eax, memd[ss, ebp - 0x70]);         /* mov eax, [ebp-0x70] */
            ii(0x1012_fae6, 1); push(eax);                              /* push eax */
            ii(0x1012_fae7, 4); movsx(edx, memw[ss, ebp - 0x5c]);       /* movsx edx, word [ebp-0x5c] */
            ii(0x1012_faeb, 3); mov(eax, memd[ss, ebp - 0x6c]);         /* mov eax, [ebp-0x6c] */
            ii(0x1012_faee, 5); call(0x1007_6e7c, -0xb_8c77);           /* call 0x10076e7c */
            ii(0x1012_faf3, 3); mov(ebx, memd[ss, ebp - 0x70]);         /* mov ebx, [ebp-0x70] */
            ii(0x1012_faf6, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1012_fafa, 3); mov(esi, memd[ss, ebp - 0x22]);         /* mov esi, [ebp-0x22] */
            ii(0x1012_fafd, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1012_faff, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1012_fb01, 5); call(/* sys */ 0x1016_a5a0, 0x3_aa9a);  /* call 0x1016a5a0 */
            ii(0x1012_fb06, 5); push(0xa2);                             /* push 0xa2 */
            ii(0x1012_fb0b, 4); movsx(edx, memw[ss, ebp - 0x60]);       /* movsx edx, word [ebp-0x60] */
            ii(0x1012_fb0f, 3); mov(eax, memd[ss, ebp - 0x64]);         /* mov eax, [ebp-0x64] */
            ii(0x1012_fb12, 5); call(Definitions.my_min, -0xa_6393);    /* call 0x10089784 */
            ii(0x1012_fb17, 1); push(eax);                              /* push eax */
            ii(0x1012_fb18, 3); mov(eax, memd[ss, ebp - 0x68]);         /* mov eax, [ebp-0x68] */
            ii(0x1012_fb1b, 1); push(eax);                              /* push eax */
            ii(0x1012_fb1c, 4); movsx(edx, memw[ss, ebp - 0x5c]);       /* movsx edx, word [ebp-0x5c] */
            ii(0x1012_fb20, 3); mov(eax, memd[ss, ebp - 0x6c]);         /* mov eax, [ebp-0x6c] */
            ii(0x1012_fb23, 5); call(0x1007_6e7c, -0xb_8cac);           /* call 0x10076e7c */
            ii(0x1012_fb28, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1012_fb2a, 3); mov(ebx, memd[ss, ebp - 0x68]);         /* mov ebx, [ebp-0x68] */
            ii(0x1012_fb2d, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1012_fb31, 3); mov(eax, memd[ss, ebp - 0x22]);         /* mov eax, [ebp-0x22] */
            ii(0x1012_fb34, 5); call(/* sys */ 0x1016_a5a0, 0x3_aa67);  /* call 0x1016a5a0 */
        l_0x1012_fb39:
            ii(0x1012_fb39, 5); call(0x100d_51e4, -0x5_a95a);           /* call 0x100d51e4 */
            ii(0x1012_fb3e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_fb43, 3); mov(memd[ss, ebp - 0x74], eax);         /* mov [ebp-0x74], eax */
            ii(0x1012_fb46, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_fb49, 3); mov(eax, memd[ds, eax + 0x32]);         /* mov eax, [eax+0x32] */
            ii(0x1012_fb4c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_fb4f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_fb51, 2); if(jle(0x1012_fb59, 0x6)) goto l_0x1012_fb59; /* jle 0x1012fb59 */
            ii(0x1012_fb53, 4); mov(memb[ss, ebp - 0x78], 0x1);         /* mov byte [ebp-0x78], 0x1 */
            ii(0x1012_fb57, 2); jmp(0x1012_fb5d, 0x4); goto l_0x1012_fb5d; /* jmp 0x1012fb5d */
        l_0x1012_fb59:
            ii(0x1012_fb59, 4); mov(memb[ss, ebp - 0x78], 0);           /* mov byte [ebp-0x78], 0x0 */
        l_0x1012_fb5d:
            ii(0x1012_fb5d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_fb5f, 3); mov(dl, memb[ss, ebp - 0x78]);          /* mov dl, [ebp-0x78] */
            ii(0x1012_fb62, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_fb65, 6); mov(eax, memd[ds, eax + 0xce]);         /* mov eax, [eax+0xce] */
            ii(0x1012_fb6b, 3); mov(ebx, memd[ss, ebp - 0x74]);         /* mov ebx, [ebp-0x74] */
            ii(0x1012_fb6e, 5); call(0x100c_fa7c, -0x6_00f7);           /* call 0x100cfa7c */
            ii(0x1012_fb73, 5); call(0x100d_51e4, -0x5_a994);           /* call 0x100d51e4 */
            ii(0x1012_fb78, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_fb7d, 3); mov(memd[ss, ebp - 0x7c], eax);         /* mov [ebp-0x7c], eax */
            ii(0x1012_fb80, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_fb83, 3); mov(edx, memd[ds, eax + 0x32]);         /* mov edx, [eax+0x32] */
            ii(0x1012_fb86, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_fb89, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_fb8c, 3); mov(eax, memd[ds, eax + 0x3c]);         /* mov eax, [eax+0x3c] */
            ii(0x1012_fb8f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_fb92, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_fb94, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_fb97, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1012_fb9a, 5); call(Definitions.my_1_get_count, -0x8_46c7); /* call 0x100ab4d8 */
            ii(0x1012_fb9f, 1); cwde();                                 /* cwde */
            ii(0x1012_fba0, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1012_fba2, 2); if(jge(0x1012_fbaa, 0x6)) goto l_0x1012_fbaa; /* jge 0x1012fbaa */
            ii(0x1012_fba4, 4); mov(memb[ss, ebp - 0x80], 0x1);         /* mov byte [ebp-0x80], 0x1 */
            ii(0x1012_fba8, 2); jmp(0x1012_fbae, 0x4); goto l_0x1012_fbae; /* jmp 0x1012fbae */
        l_0x1012_fbaa:
            ii(0x1012_fbaa, 4); mov(memb[ss, ebp - 0x80], 0);           /* mov byte [ebp-0x80], 0x0 */
        l_0x1012_fbae:
            ii(0x1012_fbae, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_fbb0, 3); mov(dl, memb[ss, ebp - 0x80]);          /* mov dl, [ebp-0x80] */
            ii(0x1012_fbb3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_fbb6, 6); mov(eax, memd[ds, eax + 0xd2]);         /* mov eax, [eax+0xd2] */
            ii(0x1012_fbbc, 3); mov(ebx, memd[ss, ebp - 0x7c]);         /* mov ebx, [ebp-0x7c] */
            ii(0x1012_fbbf, 5); call(0x100c_fa7c, -0x6_0148);           /* call 0x100cfa7c */
            ii(0x1012_fbc4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_fbc6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_fbc7, 1); pop(edi);                               /* pop edi */
            ii(0x1012_fbc8, 1); pop(esi);                               /* pop esi */
            ii(0x1012_fbc9, 1); pop(edx);                               /* pop edx */
            ii(0x1012_fbca, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_fbcb, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_fbcc, 1); ret();                                  /* ret */
        }
    }
}
