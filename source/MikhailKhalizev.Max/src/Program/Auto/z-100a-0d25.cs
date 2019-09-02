using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_0d25-46ab3f68")]
        public void Method_100a_0d25()
        {
            ii(0x100a_0d25, 5); push(0x38);                             /* push 0x38 */
            ii(0x100a_0d2a, 5); call(Definitions.sys_check_available_stack_size, 0xc_5023); /* call 0x10165d52 */
            ii(0x100a_0d2f, 1); push(esi);                              /* push esi */
            ii(0x100a_0d30, 1); push(edi);                              /* push edi */
            ii(0x100a_0d31, 1); push(ebp);                              /* push ebp */
            ii(0x100a_0d32, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_0d34, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100a_0d3a, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_0d3d, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x100a_0d40, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x100a_0d43, 3); mov(memb[ss, ebp - 4], cl);             /* mov [ebp-0x4], cl */
            ii(0x100a_0d46, 4); cmp(memd[ss, ebp - 8], 0);              /* cmp dword [ebp-0x8], 0x0 */
            ii(0x100a_0d4a, 2); if(jg(0x100a_0d58, 0xc)) goto l_0x100a_0d58; /* jg 0x100a0d58 */
            ii(0x100a_0d4c, 7); mov(memd[ss, ebp - 0x14], 1);           /* mov dword [ebp-0x14], 0x1 */
            ii(0x100a_0d53, 5); jmp(0x100a_0f6e, 0x216); goto l_0x100a_0f6e; /* jmp 0x100a0f6e */
        l_0x100a_0d58:
            ii(0x100a_0d58, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_0d5b, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100a_0d5e, 2); jmp(0x100a_0dad, 0x4d); goto l_0x100a_0dad; /* jmp 0x100a0dad */
        l_0x100a_0d60:
            ii(0x100a_0d60, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0d63, 3); mov(edx, memd[ds, eax + 0x36]);         /* mov edx, [eax+0x36] */
            ii(0x100a_0d66, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_0d69, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0d6c, 3); mov(eax, memd[ds, eax + 0x1e]);         /* mov eax, [eax+0x1e] */
            ii(0x100a_0d6f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_0d72, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100a_0d74, 3); mov(memd[ss, ebp - 0x1c], edx);         /* mov [ebp-0x1c], edx */
            ii(0x100a_0d77, 2); jmp(0x100a_0dcc, 0x53); goto l_0x100a_0dcc; /* jmp 0x100a0dcc */
        l_0x100a_0d79:
            ii(0x100a_0d79, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0d7c, 3); mov(edx, memd[ds, eax + 0x38]);         /* mov edx, [eax+0x38] */
            ii(0x100a_0d7f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_0d82, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0d85, 3); mov(eax, memd[ds, eax + 0x20]);         /* mov eax, [eax+0x20] */
            ii(0x100a_0d88, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_0d8b, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100a_0d8d, 3); mov(memd[ss, ebp - 0x1c], edx);         /* mov [ebp-0x1c], edx */
            ii(0x100a_0d90, 2); jmp(0x100a_0dcc, 0x3a); goto l_0x100a_0dcc; /* jmp 0x100a0dcc */
        l_0x100a_0d92:
            ii(0x100a_0d92, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0d95, 3); mov(edx, memd[ds, eax + 0x34]);         /* mov edx, [eax+0x34] */
            ii(0x100a_0d98, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_0d9b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0d9e, 3); mov(eax, memd[ds, eax + 0x1c]);         /* mov eax, [eax+0x1c] */
            ii(0x100a_0da1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_0da4, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100a_0da6, 3); mov(memd[ss, ebp - 0x1c], edx);         /* mov [ebp-0x1c], edx */
            ii(0x100a_0da9, 2); jmp(0x100a_0dcc, 0x21); goto l_0x100a_0dcc; /* jmp 0x100a0dcc */
        l_0x100a_0dab:
            ii(0x100a_0dab, 2); jmp(0x100a_0dcc, 0x1f); goto l_0x100a_0dcc; /* jmp 0x100a0dcc */
        l_0x100a_0dad:
            ii(0x100a_0dad, 4); cmp(memd[ss, ebp - 0x18], 0x40);        /* cmp dword [ebp-0x18], 0x40 */
            ii(0x100a_0db1, 2); if(jb(0x100a_0dc4, 0x11)) goto l_0x100a_0dc4; /* jb 0x100a0dc4 */
            ii(0x100a_0db3, 4); cmp(memd[ss, ebp - 0x18], 0x40);        /* cmp dword [ebp-0x18], 0x40 */
            ii(0x100a_0db7, 2); if(jbe(0x100a_0d92, -0x27)) goto l_0x100a_0d92; /* jbe 0x100a0d92 */
            ii(0x100a_0db9, 7); cmp(memd[ss, ebp - 0x18], 0x80);        /* cmp dword [ebp-0x18], 0x80 */
            ii(0x100a_0dc0, 2); if(jz(0x100a_0d60, -0x62)) goto l_0x100a_0d60; /* jz 0x100a0d60 */
            ii(0x100a_0dc2, 2); jmp(0x100a_0dab, -0x19); goto l_0x100a_0dab; /* jmp 0x100a0dab */
        l_0x100a_0dc4:
            ii(0x100a_0dc4, 4); cmp(memd[ss, ebp - 0x18], 0x20);        /* cmp dword [ebp-0x18], 0x20 */
            ii(0x100a_0dc8, 2); if(jz(0x100a_0d79, -0x51)) goto l_0x100a_0d79; /* jz 0x100a0d79 */
            ii(0x100a_0dca, 2); jmp(0x100a_0dab, -0x21); goto l_0x100a_0dab; /* jmp 0x100a0dab */
        l_0x100a_0dcc:
            ii(0x100a_0dcc, 4); cmp(memd[ss, ebp - 0x1c], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100a_0dd0, 2); if(jle(0x100a_0dfe, 0x2c)) goto l_0x100a_0dfe; /* jle 0x100a0dfe */
            ii(0x100a_0dd2, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0dd5, 3); mov(edx, memd[ds, eax + 0x1e]);         /* mov edx, [eax+0x1e] */
            ii(0x100a_0dd8, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_0ddb, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0dde, 3); mov(eax, memd[ds, eax + 0x20]);         /* mov eax, [eax+0x20] */
            ii(0x100a_0de1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_0de4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100a_0de6, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0de9, 3); mov(eax, memd[ds, eax + 0x1c]);         /* mov eax, [eax+0x1c] */
            ii(0x100a_0dec, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_0def, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100a_0df1, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0df4, 3); mov(eax, memd[ds, eax + 0x40]);         /* mov eax, [eax+0x40] */
            ii(0x100a_0df7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_0dfa, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100a_0dfc, 2); if(jl(0x100a_0e00, 2)) goto l_0x100a_0e00; /* jl 0x100a0e00 */
        l_0x100a_0dfe:
            ii(0x100a_0dfe, 2); jmp(0x100a_0e1e, 0x1e); goto l_0x100a_0e1e; /* jmp 0x100a0e1e */
        l_0x100a_0e00:
            ii(0x100a_0e00, 3); mov(ecx, memd[ss, ebp - 0xc]);          /* mov ecx, [ebp-0xc] */
            ii(0x100a_0e03, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x100a_0e06, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100a_0e09, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0e0c, 3); add(eax, 2);                            /* add eax, 0x2 */
            ii(0x100a_0e0f, 5); call(0x1007_68e0, -0x2_a534);           /* call 0x100768e0 */
            ii(0x100a_0e14, 5); call(0x1014_37d1, 0xa_29b8);            /* call 0x101437d1 */
            ii(0x100a_0e19, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100a_0e1c, 2); jmp(0x100a_0e25, 7); goto l_0x100a_0e25; /* jmp 0x100a0e25 */
        l_0x100a_0e1e:
            ii(0x100a_0e1e, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
        l_0x100a_0e25:
            ii(0x100a_0e25, 3); mov(ebx, memd[ss, ebp - 0x1c]);         /* mov ebx, [ebp-0x1c] */
            ii(0x100a_0e28, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100a_0e2b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0e2e, 5); call(0x100a_0a0a, -0x429);              /* call 0x100a0a0a */
            ii(0x100a_0e33, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100a_0e36, 3); sub(memd[ss, ebp - 8], eax);            /* sub [ebp-0x8], eax */
            ii(0x100a_0e39, 3); mov(ecx, memd[ss, ebp - 8]);            /* mov ecx, [ebp-0x8] */
            ii(0x100a_0e3c, 5); mov(ebx, 0x40);                         /* mov ebx, 0x40 */
            ii(0x100a_0e41, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100a_0e44, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0e47, 5); call(0x100a_0b47, -0x305);              /* call 0x100a0b47 */
            ii(0x100a_0e4c, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100a_0e4f, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100a_0e52, 3); sub(memd[ss, ebp - 8], eax);            /* sub [ebp-0x8], eax */
            ii(0x100a_0e55, 3); mov(ecx, memd[ss, ebp - 8]);            /* mov ecx, [ebp-0x8] */
            ii(0x100a_0e58, 5); mov(ebx, 0x80);                         /* mov ebx, 0x80 */
            ii(0x100a_0e5d, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100a_0e60, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0e63, 5); call(0x100a_0b47, -0x321);              /* call 0x100a0b47 */
            ii(0x100a_0e68, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100a_0e6b, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100a_0e6e, 3); sub(memd[ss, ebp - 8], eax);            /* sub [ebp-0x8], eax */
            ii(0x100a_0e71, 3); mov(ecx, memd[ss, ebp - 8]);            /* mov ecx, [ebp-0x8] */
            ii(0x100a_0e74, 5); mov(ebx, 0x20);                         /* mov ebx, 0x20 */
            ii(0x100a_0e79, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100a_0e7c, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0e7f, 5); call(0x100a_0b47, -0x33d);              /* call 0x100a0b47 */
            ii(0x100a_0e84, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100a_0e87, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100a_0e8a, 3); sub(memd[ss, ebp - 8], eax);            /* sub [ebp-0x8], eax */
            ii(0x100a_0e8d, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100a_0e90, 3); add(eax, memd[ss, ebp - 0x24]);         /* add eax, [ebp-0x24] */
            ii(0x100a_0e93, 3); add(eax, memd[ss, ebp - 0x28]);         /* add eax, [ebp-0x28] */
            ii(0x100a_0e96, 3); add(memd[ss, ebp - 0x1c], eax);         /* add [ebp-0x1c], eax */
            ii(0x100a_0e99, 4); cmp(memd[ss, ebp - 0x1c], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100a_0e9d, 2); if(jz(0x100a_0ead, 0xe)) goto l_0x100a_0ead; /* jz 0x100a0ead */
            ii(0x100a_0e9f, 4); cmp(memd[ss, ebp - 8], 0);              /* cmp dword [ebp-0x8], 0x0 */
            ii(0x100a_0ea3, 2); if(jz(0x100a_0eab, 6)) goto l_0x100a_0eab; /* jz 0x100a0eab */
            ii(0x100a_0ea5, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100a_0ea9, 2); if(jz(0x100a_0ead, 2)) goto l_0x100a_0ead; /* jz 0x100a0ead */
        l_0x100a_0eab:
            ii(0x100a_0eab, 2); jmp(0x100a_0eaf, 2); goto l_0x100a_0eaf; /* jmp 0x100a0eaf */
        l_0x100a_0ead:
            ii(0x100a_0ead, 2); jmp(0x100a_0eba, 0xb); goto l_0x100a_0eba; /* jmp 0x100a0eba */
        l_0x100a_0eaf:
            ii(0x100a_0eaf, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100a_0eb2, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100a_0eb5, 5); jmp(0x100a_0f6e, 0xb4); goto l_0x100a_0f6e; /* jmp 0x100a0f6e */
        l_0x100a_0eba:
            ii(0x100a_0eba, 3); mov(ebx, memd[ss, ebp - 0x1c]);         /* mov ebx, [ebp-0x1c] */
            ii(0x100a_0ebd, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100a_0ec0, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0ec3, 3); add(eax, 2);                            /* add eax, 0x2 */
            ii(0x100a_0ec6, 5); call(0x1007_68e0, -0x2_a5eb);           /* call 0x100768e0 */
            ii(0x100a_0ecb, 5); call(0x1014_3b69, 0xa_2c99);            /* call 0x10143b69 */
            ii(0x100a_0ed0, 3); mov(ebx, memd[ss, ebp - 0x1c]);         /* mov ebx, [ebp-0x1c] */
            ii(0x100a_0ed3, 2); neg(ebx);                               /* neg ebx */
            ii(0x100a_0ed5, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100a_0ed8, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0edb, 5); call(0x100a_0a0a, -0x4d6);              /* call 0x100a0a0a */
            ii(0x100a_0ee0, 5); mov(ecx, 0x40);                         /* mov ecx, 0x40 */
            ii(0x100a_0ee5, 3); mov(ebx, memd[ss, ebp - 0x20]);         /* mov ebx, [ebp-0x20] */
            ii(0x100a_0ee8, 5); mov(edx, 0x40);                         /* mov edx, 0x40 */
            ii(0x100a_0eed, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0ef0, 3); add(eax, 2);                            /* add eax, 0x2 */
            ii(0x100a_0ef3, 5); call(0x1007_68e0, -0x2_a618);           /* call 0x100768e0 */
            ii(0x100a_0ef8, 5); call(0x1014_37d1, 0xa_28d4);            /* call 0x101437d1 */
            ii(0x100a_0efd, 5); mov(ecx, 0x80);                         /* mov ecx, 0x80 */
            ii(0x100a_0f02, 3); mov(ebx, memd[ss, ebp - 0x24]);         /* mov ebx, [ebp-0x24] */
            ii(0x100a_0f05, 5); mov(edx, 0x80);                         /* mov edx, 0x80 */
            ii(0x100a_0f0a, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0f0d, 3); add(eax, 2);                            /* add eax, 0x2 */
            ii(0x100a_0f10, 5); call(0x1007_68e0, -0x2_a635);           /* call 0x100768e0 */
            ii(0x100a_0f15, 5); call(0x1014_37d1, 0xa_28b7);            /* call 0x101437d1 */
            ii(0x100a_0f1a, 5); mov(ecx, 0x20);                         /* mov ecx, 0x20 */
            ii(0x100a_0f1f, 3); mov(ebx, memd[ss, ebp - 0x28]);         /* mov ebx, [ebp-0x28] */
            ii(0x100a_0f22, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x100a_0f27, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0f2a, 3); add(eax, 2);                            /* add eax, 0x2 */
            ii(0x100a_0f2d, 5); call(0x1007_68e0, -0x2_a652);           /* call 0x100768e0 */
            ii(0x100a_0f32, 5); call(0x1014_37d1, 0xa_289a);            /* call 0x101437d1 */
            ii(0x100a_0f37, 3); mov(ebx, memd[ss, ebp - 0x20]);         /* mov ebx, [ebp-0x20] */
            ii(0x100a_0f3a, 5); mov(edx, 0x40);                         /* mov edx, 0x40 */
            ii(0x100a_0f3f, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0f42, 5); call(0x100a_0a0a, -0x53d);              /* call 0x100a0a0a */
            ii(0x100a_0f47, 3); mov(ebx, memd[ss, ebp - 0x24]);         /* mov ebx, [ebp-0x24] */
            ii(0x100a_0f4a, 5); mov(edx, 0x80);                         /* mov edx, 0x80 */
            ii(0x100a_0f4f, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0f52, 5); call(0x100a_0a0a, -0x54d);              /* call 0x100a0a0a */
            ii(0x100a_0f57, 3); mov(ebx, memd[ss, ebp - 0x28]);         /* mov ebx, [ebp-0x28] */
            ii(0x100a_0f5a, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x100a_0f5f, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0f62, 5); call(0x100a_0a0a, -0x55d);              /* call 0x100a0a0a */
            ii(0x100a_0f67, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
        l_0x100a_0f6e:
            ii(0x100a_0f6e, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100a_0f71, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_0f73, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_0f74, 1); pop(edi);                               /* pop edi */
            ii(0x100a_0f75, 1); pop(esi);                               /* pop esi */
            ii(0x100a_0f76, 1); ret();                                  /* ret */
        }
    }
}
