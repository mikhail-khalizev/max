using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_7017-49971b79")]
        public void Method_100a_7017()
        {
            ii(0x100a_7017, 5); push(0x3c);                             /* push 0x3c */
            ii(0x100a_701c, 5); call(Definitions.sys_check_available_stack_size, 0xb_ed31); /* call 0x10165d52 */
            ii(0x100a_7021, 1); push(ebx);                              /* push ebx */
            ii(0x100a_7022, 1); push(ecx);                              /* push ecx */
            ii(0x100a_7023, 1); push(edx);                              /* push edx */
            ii(0x100a_7024, 1); push(esi);                              /* push esi */
            ii(0x100a_7025, 1); push(edi);                              /* push edi */
            ii(0x100a_7026, 1); push(ebp);                              /* push ebp */
            ii(0x100a_7027, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_7029, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100a_702f, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_7032, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_7034, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_7037, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_703a, 5); call(0x1013_ad11, 0x9_3cd2);            /* call 0x1013ad11 */
            ii(0x100a_703f, 2); test(al, al);                           /* test al, al */
            ii(0x100a_7041, 2); if(jnz(0x100a_7058, 0x15)) goto l_0x100a_7058; /* jnz 0x100a7058 */
            ii(0x100a_7043, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_7046, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_7049, 5); call(0x1007_6574, -0x3_0ada);           /* call 0x10076574 */
            ii(0x100a_704e, 5); call(0x1015_26ac, 0xa_b659);            /* call 0x101526ac */
            ii(0x100a_7053, 3); cmp(eax, memd[ss, ebp - 0x4]);          /* cmp eax, [ebp-0x4] */
            ii(0x100a_7056, 2); if(jz(0x100a_705d, 0x5)) goto l_0x100a_705d; /* jz 0x100a705d */
        l_0x100a_7058:
            ii(0x100a_7058, 5); jmp(0x100a_719b, 0x13e); goto l_0x100a_719b; /* jmp 0x100a719b */
        l_0x100a_705d:
            ii(0x100a_705d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_705f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_7062, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x100a_7065, 5); call(0x1013_ad11, 0x9_3ca7);            /* call 0x1013ad11 */
            ii(0x100a_706a, 2); test(al, al);                           /* test al, al */
            ii(0x100a_706c, 2); if(jz(0x100a_7076, 0x8)) goto l_0x100a_7076; /* jz 0x100a7076 */
            ii(0x100a_706e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_7071, 5); call(0x100a_6df3, -0x283);              /* call 0x100a6df3 */
        l_0x100a_7076:
            ii(0x100a_7076, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_7078, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_707b, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x100a_707e, 5); call(0x1013_ad11, 0x9_3c8e);            /* call 0x1013ad11 */
            ii(0x100a_7083, 2); test(al, al);                           /* test al, al */
            ii(0x100a_7085, 2); if(jnz(0x100a_709c, 0x15)) goto l_0x100a_709c; /* jnz 0x100a709c */
            ii(0x100a_7087, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_708a, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x100a_708d, 5); call(0x1007_6574, -0x3_0b1e);           /* call 0x10076574 */
            ii(0x100a_7092, 5); call(0x1015_26ac, 0xa_b615);            /* call 0x101526ac */
            ii(0x100a_7097, 3); cmp(eax, memd[ss, ebp - 0x4]);          /* cmp eax, [ebp-0x4] */
            ii(0x100a_709a, 2); if(jz(0x100a_70a1, 0x5)) goto l_0x100a_70a1; /* jz 0x100a70a1 */
        l_0x100a_709c:
            ii(0x100a_709c, 5); jmp(0x100a_719b, 0xfa); goto l_0x100a_719b; /* jmp 0x100a719b */
        l_0x100a_70a1:
            ii(0x100a_70a1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_70a4, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_70a7, 5); call(0x1007_6574, -0x3_0b38);           /* call 0x10076574 */
            ii(0x100a_70ac, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x100a_70af, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_70b2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_70b5, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_70b8, 5); call(0x1007_6574, -0x3_0b49);           /* call 0x10076574 */
            ii(0x100a_70bd, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x100a_70c0, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_70c3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_70c6, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100a_70c9, 5); call(0x1008_abbc, -0x1_c512);           /* call 0x1008abbc */
            ii(0x100a_70ce, 5); call(0x100a_30a2, -0x4031);             /* call 0x100a30a2 */
            ii(0x100a_70d3, 2); test(al, al);                           /* test al, al */
            ii(0x100a_70d5, 6); if(jnz(0x100a_715b, 0x80)) goto l_0x100a_715b; /* jnz 0x100a715b */
            ii(0x100a_70db, 5); mov(eax, 0x1f);                         /* mov eax, 0x1f */
            ii(0x100a_70e0, 5); call(Definitions.sys_new, 0xb_ed1b);    /* call 0x10165e00 */
            ii(0x100a_70e5, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_70e8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_70eb, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_70ee, 4); cmp(memd[ss, ebp - 0xc], 0);            /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100a_70f2, 2); if(jz(0x100a_712a, 0x36)) goto l_0x100a_712a; /* jz 0x100a712a */
            ii(0x100a_70f4, 5); mov(eax, 0x100a_71a4);                  /* mov eax, 0x100a71a4 */
            ii(0x100a_70f9, 1); push(eax);                              /* push eax */
            ii(0x100a_70fa, 3); mov(ecx, memd[ss, ebp - 0x4]);          /* mov ecx, [ebp-0x4] */
            ii(0x100a_70fd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_7100, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100a_7103, 5); call(0x1007_65d0, -0x3_0b38);           /* call 0x100765d0 */
            ii(0x100a_7108, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100a_710a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_710d, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_7110, 5); call(0x1007_65d0, -0x3_0b45);           /* call 0x100765d0 */
            ii(0x100a_7115, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_7117, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_711a, 5); call(0x100b_43b0, 0xd291);              /* call 0x100b43b0 */
            ii(0x100a_711f, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_7122, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_7125, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100a_7128, 2); jmp(0x100a_7130, 0x6); goto l_0x100a_7130; /* jmp 0x100a7130 */
        l_0x100a_712a:
            ii(0x100a_712a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_712d, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
        l_0x100a_7130:
            ii(0x100a_7130, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x100a_7133, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_7136, 5); call(0x1008_b060, -0x1_c0db);           /* call 0x1008b060 */
            ii(0x100a_713b, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_713e, 5); call(0x1008_af84, -0x1_c1bf);           /* call 0x1008af84 */
            ii(0x100a_7143, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_7145, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_714a, 5); call(0x100a_4d50, -0x23ff);             /* call 0x100a4d50 */
            ii(0x100a_714f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_7151, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_7154, 5); call(0x1008_8b7c, -0x1_e5dd);           /* call 0x10088b7c */
            ii(0x100a_7159, 2); jmp(0x100a_719b, 0x40); goto l_0x100a_719b; /* jmp 0x100a719b */
        l_0x100a_715b:
            ii(0x100a_715b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_715d, 5); mov(al, memb[ds, 0x101c_37c9]);         /* mov al, [0x101c37c9] */
            ii(0x100a_7162, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_7164, 2); if(jnz(0x100a_717b, 0x15)) goto l_0x100a_717b; /* jnz 0x100a717b */
            ii(0x100a_7166, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_7169, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x100a_716c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_716f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_7171, 6); mov(dl, memb[ds, 0x101c_37c8]);         /* mov dl, [0x101c37c8] */
            ii(0x100a_7177, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_7179, 2); if(jnz(0x100a_7187, 0xc)) goto l_0x100a_7187; /* jnz 0x100a7187 */
        l_0x100a_717b:
            ii(0x100a_717b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_717d, 5); mov(al, memb[ds, 0x101c_37c9]);         /* mov al, [0x101c37c9] */
            ii(0x100a_7182, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100a_7185, 2); if(jnz(0x100a_7189, 0x2)) goto l_0x100a_7189; /* jnz 0x100a7189 */
        l_0x100a_7187:
            ii(0x100a_7187, 2); jmp(0x100a_719b, 0x12); goto l_0x100a_719b; /* jmp 0x100a719b */
        l_0x100a_7189:
            ii(0x100a_7189, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_718c, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100a_718f, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100a_7192, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x100a_7195, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100a_7198, 3); call_abs(memd[ds, edx + 0x70]);         /* call dword [edx+0x70] */
        l_0x100a_719b:
            ii(0x100a_719b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_719d, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_719e, 1); pop(edi);                               /* pop edi */
            ii(0x100a_719f, 1); pop(esi);                               /* pop esi */
            ii(0x100a_71a0, 1); pop(edx);                               /* pop edx */
            ii(0x100a_71a1, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_71a2, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_71a3, 1); ret();                                  /* ret */
        }
    }
}
