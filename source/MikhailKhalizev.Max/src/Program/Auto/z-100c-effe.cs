using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_effe-7de99b7a")]
        public void Method_100c_effe()
        {
            ii(0x100c_effe, 5); push(0x54);                             /* push 0x54 */
            ii(0x100c_f003, 5); call(Definitions.sys_check_available_stack_size, 0x9_6d4a); /* call 0x10165d52 */
            ii(0x100c_f008, 1); push(ebx);                              /* push ebx */
            ii(0x100c_f009, 1); push(ecx);                              /* push ecx */
            ii(0x100c_f00a, 1); push(esi);                              /* push esi */
            ii(0x100c_f00b, 1); push(edi);                              /* push edi */
            ii(0x100c_f00c, 1); push(ebp);                              /* push ebp */
            ii(0x100c_f00d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_f00f, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x100c_f015, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_f018, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_f01b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f01e, 4); cmp(memd[ds, eax + 0x14], 0);           /* cmp dword [eax+0x14], 0x0 */
            ii(0x100c_f022, 2); if(jz(0x100c_f04e, 0x2a)) goto l_0x100c_f04e; /* jz 0x100cf04e */
            ii(0x100c_f024, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f027, 3); mov(eax, memd[ds, eax + 0x14]);         /* mov eax, [eax+0x14] */
            ii(0x100c_f02a, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100c_f02d, 4); cmp(memd[ss, ebp - 0x28], 0);           /* cmp dword [ebp-0x28], 0x0 */
            ii(0x100c_f031, 2); if(jz(0x100c_f047, 0x14)) goto l_0x100c_f047; /* jz 0x100cf047 */
            ii(0x100c_f033, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_f035, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100c_f038, 5); call(Definitions.my_dtor_d3, 0x8cf6);   /* call 0x100d7d33 */
            ii(0x100c_f03d, 5); call(Definitions.sys_delete, 0x9_6f22); /* call 0x10165f64 */
            ii(0x100c_f042, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100c_f045, 2); jmp(0x100c_f04e, 0x7); goto l_0x100c_f04e; /* jmp 0x100cf04e */
        l_0x100c_f047:
            ii(0x100c_f047, 7); mov(memd[ss, ebp - 0x24], 0);           /* mov dword [ebp-0x24], 0x0 */
        l_0x100c_f04e:
            ii(0x100c_f04e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f051, 4); cmp(memd[ds, eax + 0x18], 0);           /* cmp dword [eax+0x18], 0x0 */
            ii(0x100c_f055, 2); if(jz(0x100c_f081, 0x2a)) goto l_0x100c_f081; /* jz 0x100cf081 */
            ii(0x100c_f057, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f05a, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x100c_f05d, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100c_f060, 4); cmp(memd[ss, ebp - 0x30], 0);           /* cmp dword [ebp-0x30], 0x0 */
            ii(0x100c_f064, 2); if(jz(0x100c_f07a, 0x14)) goto l_0x100c_f07a; /* jz 0x100cf07a */
            ii(0x100c_f066, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_f068, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_f06b, 5); call(Definitions.my_dtor_d3, 0x8cc3);   /* call 0x100d7d33 */
            ii(0x100c_f070, 5); call(Definitions.sys_delete, 0x9_6eef); /* call 0x10165f64 */
            ii(0x100c_f075, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100c_f078, 2); jmp(0x100c_f081, 0x7); goto l_0x100c_f081; /* jmp 0x100cf081 */
        l_0x100c_f07a:
            ii(0x100c_f07a, 7); mov(memd[ss, ebp - 0x2c], 0);           /* mov dword [ebp-0x2c], 0x0 */
        l_0x100c_f081:
            ii(0x100c_f081, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100c_f086, 5); call(Definitions.sys_new, 0x9_6d75);    /* call 0x10165e00 */
            ii(0x100c_f08b, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100c_f08e, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100c_f091, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100c_f094, 4); cmp(memd[ss, ebp - 0x1c], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100c_f098, 2); if(jz(0x100c_f0d2, 0x38)) goto l_0x100c_f0d2; /* jz 0x100cf0d2 */
            ii(0x100c_f09a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f09d, 3); mov(eax, memd[ds, eax + 0x8]);          /* mov eax, [eax+0x8] */
            ii(0x100c_f0a0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_f0a3, 1); push(eax);                              /* push eax */
            ii(0x100c_f0a4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f0a7, 3); mov(ecx, memd[ds, eax + 0x6]);          /* mov ecx, [eax+0x6] */
            ii(0x100c_f0aa, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_f0ad, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f0b0, 3); mov(ebx, memd[ds, eax + 0x4]);          /* mov ebx, [eax+0x4] */
            ii(0x100c_f0b3, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_f0b6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f0b9, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x100c_f0bc, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_f0bf, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100c_f0c2, 5); call(0x100d_7bdc, 0x8b15);              /* call 0x100d7bdc */
            ii(0x100c_f0c7, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100c_f0ca, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100c_f0cd, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x100c_f0d0, 2); jmp(0x100c_f0d8, 0x6); goto l_0x100c_f0d8; /* jmp 0x100cf0d8 */
        l_0x100c_f0d2:
            ii(0x100c_f0d2, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100c_f0d5, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
        l_0x100c_f0d8:
            ii(0x100c_f0d8, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x100c_f0db, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_f0de, 3); mov(memd[ds, edx + 0x14], eax);         /* mov [edx+0x14], eax */
            ii(0x100c_f0e1, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100c_f0e6, 5); call(Definitions.sys_new, 0x9_6d15);    /* call 0x10165e00 */
            ii(0x100c_f0eb, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_f0ee, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_f0f1, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_f0f4, 4); cmp(memd[ss, ebp - 0x10], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100c_f0f8, 2); if(jz(0x100c_f132, 0x38)) goto l_0x100c_f132; /* jz 0x100cf132 */
            ii(0x100c_f0fa, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f0fd, 3); mov(eax, memd[ds, eax + 0x8]);          /* mov eax, [eax+0x8] */
            ii(0x100c_f100, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_f103, 1); push(eax);                              /* push eax */
            ii(0x100c_f104, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f107, 3); mov(ecx, memd[ds, eax + 0x6]);          /* mov ecx, [eax+0x6] */
            ii(0x100c_f10a, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_f10d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f110, 3); mov(ebx, memd[ds, eax + 0x4]);          /* mov ebx, [eax+0x4] */
            ii(0x100c_f113, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_f116, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f119, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x100c_f11c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_f11f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_f122, 5); call(0x100d_7bdc, 0x8ab5);              /* call 0x100d7bdc */
            ii(0x100c_f127, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_f12a, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_f12d, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x100c_f130, 2); jmp(0x100c_f138, 0x6); goto l_0x100c_f138; /* jmp 0x100cf138 */
        l_0x100c_f132:
            ii(0x100c_f132, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_f135, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
        l_0x100c_f138:
            ii(0x100c_f138, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x100c_f13b, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_f13e, 3); mov(memd[ds, edx + 0x18], eax);         /* mov [edx+0x18], eax */
            ii(0x100c_f141, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_f144, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f147, 3); mov(eax, memd[ds, eax + 0x14]);         /* mov eax, [eax+0x14] */
            ii(0x100c_f14a, 5); call(0x100d_7d74, 0x8c25);              /* call 0x100d7d74 */
            ii(0x100c_f14f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f152, 3); mov(edx, memd[ds, eax + 0x14]);         /* mov edx, [eax+0x14] */
            ii(0x100c_f155, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f158, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x100c_f15b, 5); call(0x100d_7e01, 0x8ca1);              /* call 0x100d7e01 */
            ii(0x100c_f160, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_f162, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_f163, 1); pop(edi);                               /* pop edi */
            ii(0x100c_f164, 1); pop(esi);                               /* pop esi */
            ii(0x100c_f165, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_f166, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_f167, 1); ret();                                  /* ret */
        }
    }
}
