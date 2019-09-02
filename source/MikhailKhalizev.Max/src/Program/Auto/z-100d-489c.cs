using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_489c-20b8b44a")]
        public void Method_100d_489c()
        {
            ii(0x100d_489c, 5); push(0x68);                             /* push 0x68 */
            ii(0x100d_48a1, 5); call(Definitions.sys_check_available_stack_size, 0x9_14ac); /* call 0x10165d52 */
            ii(0x100d_48a6, 1); push(ebx);                              /* push ebx */
            ii(0x100d_48a7, 1); push(ecx);                              /* push ecx */
            ii(0x100d_48a8, 1); push(edx);                              /* push edx */
            ii(0x100d_48a9, 1); push(esi);                              /* push esi */
            ii(0x100d_48aa, 1); push(edi);                              /* push edi */
            ii(0x100d_48ab, 1); push(ebp);                              /* push ebp */
            ii(0x100d_48ac, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_48ae, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x100d_48b4, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100d_48b7, 3); lea(edx, memd[ss, ebp - 0x14]);         /* lea edx, [ebp-0x14] */
            ii(0x100d_48ba, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_48bd, 3); mov(eax, memd[ds, eax + 0x31]);         /* mov eax, [eax+0x31] */
            ii(0x100d_48c0, 5); call(0x1015_0a5f, 0x7_c19a);            /* call 0x10150a5f */
            ii(0x100d_48c5, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100d_48c8, 5); call(0x1009_caf8, -0x3_7dd5);           /* call 0x1009caf8 */
            ii(0x100d_48cd, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x100d_48d4, 2); jmp(0x100d_48dc, 6); goto l_0x100d_48dc; /* jmp 0x100d48dc */
        l_0x100d_48d6:
            ii(0x100d_48d6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_48d9, 3); inc(memd[ss, ebp - 0xc]);               /* inc dword [ebp-0xc] */
        l_0x100d_48dc:
            ii(0x100d_48dc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_48df, 5); add(eax, 0x87);                         /* add eax, 0x87 */
            ii(0x100d_48e4, 5); call(Definitions.my_2_get_count, -0x4_9581); /* call 0x1008b368 */
            ii(0x100d_48e9, 4); cmp(ax, memw[ss, ebp - 0xc]);           /* cmp ax, [ebp-0xc] */
            ii(0x100d_48ed, 2); if(jle(0x100d_490c, 0x1d)) goto l_0x100d_490c; /* jle 0x100d490c */
            ii(0x100d_48ef, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x100d_48f3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_48f6, 5); add(eax, 0x87);                         /* add eax, 0x87 */
            ii(0x100d_48fb, 5); call(0x1008_b228, -0x4_96d8);           /* call 0x1008b228 */
            ii(0x100d_4900, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_4902, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100d_4905, 5); call(0x1008_b2a8, -0x4_9662);           /* call 0x1008b2a8 */
            ii(0x100d_490a, 2); jmp(0x100d_48d6, -0x36); goto l_0x100d_48d6; /* jmp 0x100d48d6 */
        l_0x100d_490c:
            ii(0x100d_490c, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100d_490f, 5); call(Definitions.my_2_get_count, -0x4_95ac); /* call 0x1008b368 */
            ii(0x100d_4914, 1); cwde();                                 /* cwde */
            ii(0x100d_4915, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_4917, 2); if(jnz(0x100d_4944, 0x2b)) goto l_0x100d_4944; /* jnz 0x100d4944 */
            ii(0x100d_4919, 5); mov(ebx, 0xd);                          /* mov ebx, 0xd */
            ii(0x100d_491e, 5); mov(edx, 0x15);                         /* mov edx, 0x15 */
            ii(0x100d_4923, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_4926, 3); mov(eax, memd[ds, eax + 0x31]);         /* mov eax, [eax+0x31] */
            ii(0x100d_4929, 5); call(0x1016_3053, 0x8_e725);            /* call 0x10163053 */
            ii(0x100d_492e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_4931, 4); mov(memb[ds, eax + 0x36], 1);           /* mov byte [eax+0x36], 0x1 */
            ii(0x100d_4935, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_4937, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100d_493a, 5); call(0x1008_8b04, -0x4_be3b);           /* call 0x10088b04 */
            ii(0x100d_493f, 5); jmp(0x100d_4a95, 0x151); goto l_0x100d_4a95; /* jmp 0x100d4a95 */
        l_0x100d_4944:
            ii(0x100d_4944, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_4946, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100d_4949, 5); call(0x1008_b228, -0x4_9726);           /* call 0x1008b228 */
            ii(0x100d_494e, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100d_4951, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_4954, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100d_4958, 3); imul(edx, edx, 0x33);                   /* imul edx, edx, 0x33 */
            ii(0x100d_495b, 5); mov(eax, 0x101c_81c0);                  /* mov eax, 0x101c81c0 */
            ii(0x100d_4960, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_4962, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100d_4965, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_4968, 4); mov(memb[ds, eax + 0x36], 1);           /* mov byte [eax+0x36], 0x1 */
            ii(0x100d_496c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_496f, 4); mov(memb[ds, eax + 0x35], 1);           /* mov byte [eax+0x35], 0x1 */
            ii(0x100d_4973, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_4976, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_4979, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_497c, 3); mov(ebx, memd[ds, eax + 0x13]);         /* mov ebx, [eax+0x13] */
            ii(0x100d_497f, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100d_4983, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_4986, 3); call_abs(memd[ds, ebx + 0x10]);         /* call dword [ebx+0x10] */
            ii(0x100d_4989, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_498b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_498e, 3); mov(eax, memd[ds, eax + 0x31]);         /* mov eax, [eax+0x31] */
            ii(0x100d_4991, 3); mov(memb[ds, eax + 0x45], dl);          /* mov [eax+0x45], dl */
            ii(0x100d_4994, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_4997, 3); mov(edx, memd[ds, eax + 0x36]);         /* mov edx, [eax+0x36] */
            ii(0x100d_499a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_499d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_49a0, 3); mov(eax, memd[ds, eax + 0x31]);         /* mov eax, [eax+0x31] */
            ii(0x100d_49a3, 5); call(0x1009_c970, -0x3_8038);           /* call 0x1009c970 */
            ii(0x100d_49a8, 4); or(memb[ss, ebp - 8], 1);               /* or byte [ebp-0x8], 0x1 */
            ii(0x100d_49ac, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100d_49af, 5); call(Definitions.my_string_ctor, 0x6_d134); /* call 0x10141ae8 */
            ii(0x100d_49b4, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100d_49b7, 4); and(memb[ss, ebp - 8], -2 /* 0xfe */);  /* and byte [ebp-0x8], 0xfe */
            ii(0x100d_49bb, 3); lea(edi, memd[ss, ebp - 0x30]);         /* lea edi, [ebp-0x30] */
            ii(0x100d_49be, 5); mov(esi, 0x101b_7e60);                  /* mov esi, 0x101b7e60 */
            ii(0x100d_49c3, 1); movsd();                                /* movsd */
            ii(0x100d_49c4, 1); movsd();                                /* movsd */
            ii(0x100d_49c5, 1); movsd();                                /* movsd */
            ii(0x100d_49c6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_49c9, 3); mov(eax, memd[ds, eax + 0x31]);         /* mov eax, [eax+0x31] */
            ii(0x100d_49cc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_49ce, 3); mov(dl, memb[ds, eax + 0x45]);          /* mov dl, [eax+0x45] */
            ii(0x100d_49d1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_49d4, 3); mov(eax, memd[ds, eax + 0x36]);         /* mov eax, [eax+0x36] */
            ii(0x100d_49d7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_49da, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_49dc, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x100d_49df, 3); mov(ebx, memd[ds, ebx + 0x36]);         /* mov ebx, [ebx+0x36] */
            ii(0x100d_49e2, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_49e5, 1); dec(edx);                               /* dec edx */
            ii(0x100d_49e6, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_49e8, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_49eb, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100d_49ed, 1); push(eax);                              /* push eax */
            ii(0x100d_49ee, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_49f1, 3); mov(eax, memd[ds, eax + 0x31]);         /* mov eax, [eax+0x31] */
            ii(0x100d_49f4, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x100d_49f7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100d_49fc, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100d_4a02, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100d_4a06, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_4a08, 6); mov(al, memb[ds, eax + 0x101c_a492]);   /* mov al, [eax+0x101ca492] */
            ii(0x100d_4a0e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100d_4a13, 1); push(eax);                              /* push eax */
            ii(0x100d_4a14, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_4a17, 3); push(memd[ds, eax + 0x17]);             /* push dword [eax+0x17] */
            ii(0x100d_4a1a, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_4a1d, 3); mov(eax, memd[ds, eax + 0x13]);         /* mov eax, [eax+0x13] */
            ii(0x100d_4a20, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x100d_4a23, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100d_4a26, 4); push(memd[ds, eax + ebp - 0x30]);       /* push dword [eax+ebp-0x30] */
            ii(0x100d_4a2a, 5); mov(eax, 0xfa);                         /* mov eax, 0xfa */
            ii(0x100d_4a2f, 1); push(eax);                              /* push eax */
            ii(0x100d_4a30, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100d_4a33, 1); push(eax);                              /* push eax */
            ii(0x100d_4a34, 5); call(0x1014_2037, 0x6_d5fe);            /* call 0x10142037 */
            ii(0x100d_4a39, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x100d_4a3c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_4a3f, 3); mov(eax, memd[ds, eax + 0x31]);         /* mov eax, [eax+0x31] */
            ii(0x100d_4a42, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x100d_4a45, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_4a48, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_4a4b, 3); mov(eax, memd[ds, eax + 0x31]);         /* mov eax, [eax+0x31] */
            ii(0x100d_4a4e, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x100d_4a51, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_4a54, 3); lea(eax, memd[ss, ebp - 0x34]);         /* lea eax, [ebp-0x34] */
            ii(0x100d_4a57, 5); call(0x1007_6aac, -0x5_dfb0);           /* call 0x10076aac */
            ii(0x100d_4a5c, 2); mov(ecx, memd[ds, eax]);                /* mov ecx, [eax] */
            ii(0x100d_4a5e, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x100d_4a61, 3); mov(ebx, memd[ds, ebx + 0x31]);         /* mov ebx, [ebx+0x31] */
            ii(0x100d_4a64, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100d_4a69, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100d_4a6c, 5); call(Definitions.my_strobj_c_str_v2, -0x4_b2a9); /* call 0x100897c8 */
            ii(0x100d_4a71, 5); call(0x1011_5b60, 0x4_10ea);            /* call 0x10115b60 */
            ii(0x100d_4a76, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_4a79, 3); mov(eax, memd[ds, eax + 0x31]);         /* mov eax, [eax+0x31] */
            ii(0x100d_4a7c, 5); call(0x1015_2387, 0x7_d906);            /* call 0x10152387 */
            ii(0x100d_4a81, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_4a83, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100d_4a86, 5); call(Definitions.my_string_dtor, 0x6_d09f); /* call 0x10141b2a */
            ii(0x100d_4a8b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_4a8d, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100d_4a90, 5); call(0x1008_8b04, -0x4_bf91);           /* call 0x10088b04 */
        l_0x100d_4a95:
            ii(0x100d_4a95, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_4a97, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_4a98, 1); pop(edi);                               /* pop edi */
            ii(0x100d_4a99, 1); pop(esi);                               /* pop esi */
            ii(0x100d_4a9a, 1); pop(edx);                               /* pop edx */
            ii(0x100d_4a9b, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_4a9c, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_4a9d, 1); ret();                                  /* ret */
        }
    }
}
