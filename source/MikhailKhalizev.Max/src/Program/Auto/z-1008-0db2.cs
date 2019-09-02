using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_0db2-cbef46b9")]
        public void Method_1008_0db2()
        {
            ii(0x1008_0db2, 5); push(0x78);                             /* push 0x78 */
            ii(0x1008_0db7, 5); call(Definitions.sys_check_available_stack_size, 0xe_4f96); /* call 0x10165d52 */
            ii(0x1008_0dbc, 1); push(ebx);                              /* push ebx */
            ii(0x1008_0dbd, 1); push(ecx);                              /* push ecx */
            ii(0x1008_0dbe, 1); push(esi);                              /* push esi */
            ii(0x1008_0dbf, 1); push(edi);                              /* push edi */
            ii(0x1008_0dc0, 1); push(ebp);                              /* push ebp */
            ii(0x1008_0dc1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_0dc3, 6); sub(esp, 0x54);                         /* sub esp, 0x54 */
            ii(0x1008_0dc9, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_0dcc, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_0dcf, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_0dd2, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x1008_0dd5, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_0dda, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_0ddc, 2); if(jz(0x1008_0ded, 0xf)) goto l_0x1008_0ded; /* jz 0x10080ded */
            ii(0x1008_0dde, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1008_0de1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_0de4, 5); call(0x1015_2a52, 0xd_1c69);            /* call 0x10152a52 */
            ii(0x1008_0de9, 2); test(al, al);                           /* test al, al */
            ii(0x1008_0deb, 2); if(jnz(0x1008_0df6, 9)) goto l_0x1008_0df6; /* jnz 0x10080df6 */
        l_0x1008_0ded:
            ii(0x1008_0ded, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_0df1, 5); jmp(0x1008_10d8, 0x2e2); goto l_0x1008_10d8; /* jmp 0x100810d8 */
        l_0x1008_0df6:
            ii(0x1008_0df6, 5); mov(ebx, 3);                            /* mov ebx, 0x3 */
            ii(0x1008_0dfb, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_0dfe, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_0e01, 5); call(0x100a_3671, 0x2_286b);            /* call 0x100a3671 */
            ii(0x1008_0e06, 2); test(al, al);                           /* test al, al */
            ii(0x1008_0e08, 2); if(jz(0x1008_0e13, 9)) goto l_0x1008_0e13; /* jz 0x10080e13 */
            ii(0x1008_0e0a, 4); mov(memb[ss, ebp - 0xc], 1);            /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_0e0e, 5); jmp(0x1008_10d8, 0x2c5); goto l_0x1008_10d8; /* jmp 0x100810d8 */
        l_0x1008_0e13:
            ii(0x1008_0e13, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_0e16, 3); mov(eax, memd[ds, eax + 0x50]);         /* mov eax, [eax+0x50] */
            ii(0x1008_0e19, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_0e1c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_0e1e, 2); if(jnz(0x1008_0e7c, 0x5c)) goto l_0x1008_0e7c; /* jnz 0x10080e7c */
            ii(0x1008_0e20, 5); mov(eax, 0x21);                         /* mov eax, 0x21 */
            ii(0x1008_0e25, 5); call(Definitions.sys_new, 0xe_4fd6);    /* call 0x10165e00 */
            ii(0x1008_0e2a, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1008_0e2d, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1008_0e30, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1008_0e33, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1008_0e37, 2); if(jz(0x1008_0e60, 0x27)) goto l_0x1008_0e60; /* jz 0x10080e60 */
            ii(0x1008_0e39, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_0e3c, 5); call(0x1007_623c, -0xac05);             /* call 0x1007623c */
            ii(0x1008_0e41, 3); mov(ecx, memd[ds, eax + 0x17]);         /* mov ecx, [eax+0x17] */
            ii(0x1008_0e44, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1008_0e47, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1008_0e4a, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1008_0e4d, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1008_0e50, 5); call(0x1008_bd0b, 0xaeb6);              /* call 0x1008bd0b */
            ii(0x1008_0e55, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1008_0e58, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1008_0e5b, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1008_0e5e, 2); jmp(0x1008_0e66, 6); goto l_0x1008_0e66; /* jmp 0x10080e66 */
        l_0x1008_0e60:
            ii(0x1008_0e60, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1008_0e63, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
        l_0x1008_0e66:
            ii(0x1008_0e66, 3); mov(edx, memd[ss, ebp - 0x20]);         /* mov edx, [ebp-0x20] */
            ii(0x1008_0e69, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_0e6e, 5); call(0x100a_4d50, 0x2_3edd);            /* call 0x100a4d50 */
            ii(0x1008_0e73, 4); mov(memb[ss, ebp - 0xc], 1);            /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_0e77, 5); jmp(0x1008_10d8, 0x25c); goto l_0x1008_10d8; /* jmp 0x100810d8 */
        l_0x1008_0e7c:
            ii(0x1008_0e7c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_0e7f, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1008_0e82, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_0e85, 6); imul(edx, eax, 0xc5);                   /* imul edx, eax, 0xc5 */
            ii(0x1008_0e8b, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x1008_0e90, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_0e92, 5); call(0x1008_a0c8, 0x9231);              /* call 0x1008a0c8 */
            ii(0x1008_0e97, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_0e9a, 4); cmp(memd[ss, ebp - 0x10], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1008_0e9e, 6); if(jz(0x1008_10d4, 0x230)) goto l_0x1008_10d4; /* jz 0x100810d4 */
            ii(0x1008_0ea4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_0ea7, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x1008_0eaa, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_0ead, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1008_0eb0, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1008_0eb3, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1008_0eb5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_0eb8, 3); mov(eax, memd[ds, eax + 0x1a]);         /* mov eax, [eax+0x1a] */
            ii(0x1008_0ebb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_0ebe, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x1008_0ec0, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_0ec2, 3); test(memb[ds, eax], 2);                 /* test byte [eax], 0x2 */
            ii(0x1008_0ec5, 2); if(jz(0x1008_0f21, 0x5a)) goto l_0x1008_0f21; /* jz 0x10080f21 */
            ii(0x1008_0ec7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_0ec9, 5); mov(al, memb[ds, 0x101c_37c9]);         /* mov al, [0x101c37c9] */
            ii(0x1008_0ece, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_0ed0, 2); if(jnz(0x1008_0ee7, 0x15)) goto l_0x1008_0ee7; /* jnz 0x10080ee7 */
            ii(0x1008_0ed2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_0ed5, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1008_0ed8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_0edb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_0edd, 6); mov(dl, memb[ds, 0x101c_37c8]);         /* mov dl, [0x101c37c8] */
            ii(0x1008_0ee3, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_0ee5, 2); if(jnz(0x1008_0f18, 0x31)) goto l_0x1008_0f18; /* jnz 0x10080f18 */
        l_0x1008_0ee7:
            ii(0x1008_0ee7, 5); mov(ebx, 0x2c);                         /* mov ebx, 0x2c */
            ii(0x1008_0eec, 5); mov(edx, 0x1d);                         /* mov edx, 0x1d */
            ii(0x1008_0ef1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_0ef4, 5); call(0x1016_3053, 0xe_215a);            /* call 0x10163053 */
            ii(0x1008_0ef9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_0efc, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1008_0eff, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_0f02, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x1008_0f05, 3); add(edx, memd[ss, ebp - 0x10]);         /* add edx, [ebp-0x10] */
            ii(0x1008_0f08, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_0f0b, 3); mov(eax, memd[ds, eax + 0x1a]);         /* mov eax, [eax+0x1a] */
            ii(0x1008_0f0e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_0f11, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x1008_0f13, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_0f15, 3); and(memb[ds, eax], -3 /* 0xfd */);      /* and byte [eax], 0xfd */
        l_0x1008_0f18:
            ii(0x1008_0f18, 4); mov(memb[ss, ebp - 0xc], 1);            /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_0f1c, 5); jmp(0x1008_10d8, 0x1b7); goto l_0x1008_10d8; /* jmp 0x100810d8 */
        l_0x1008_0f21:
            ii(0x1008_0f21, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_0f24, 5); call(0x1008_aa4c, 0x9b23);              /* call 0x1008aa4c */
            ii(0x1008_0f29, 2); cmp(al, 2);                             /* cmp al, 0x2 */
            ii(0x1008_0f2b, 2); if(jnz(0x1008_0f48, 0x1b)) goto l_0x1008_0f48; /* jnz 0x10080f48 */
            ii(0x1008_0f2d, 5); mov(ebx, 0x2b);                         /* mov ebx, 0x2b */
            ii(0x1008_0f32, 5); mov(edx, 0x1d);                         /* mov edx, 0x1d */
            ii(0x1008_0f37, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_0f3a, 5); call(0x1016_3053, 0xe_2114);            /* call 0x10163053 */
            ii(0x1008_0f3f, 4); mov(memb[ss, ebp - 0xc], 1);            /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_0f43, 5); jmp(0x1008_10d8, 0x190); goto l_0x1008_10d8; /* jmp 0x100810d8 */
        l_0x1008_0f48:
            ii(0x1008_0f48, 3); lea(eax, memd[ss, ebp - 0x28]);         /* lea eax, [ebp-0x28] */
            ii(0x1008_0f4b, 5); call(Definitions.my_ctor_0x101b_4184, -0xa460); /* call 0x10076af0 */
            ii(0x1008_0f50, 4); mov(memb[ss, ebp - 0x24], 0);           /* mov byte [ebp-0x24], 0x0 */
            ii(0x1008_0f54, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_0f57, 5); cmp(memw[ds, eax + 8], 0x38);           /* cmp word [eax+0x8], 0x38 */
            ii(0x1008_0f5c, 2); if(jnz(0x1008_0f67, 9)) goto l_0x1008_0f67; /* jnz 0x10080f67 */
            ii(0x1008_0f5e, 7); mov(memd[ss, ebp - 0x2c], 1);           /* mov dword [ebp-0x2c], 0x1 */
            ii(0x1008_0f65, 2); jmp(0x1008_0f6e, 7); goto l_0x1008_0f6e; /* jmp 0x10080f6e */
        l_0x1008_0f67:
            ii(0x1008_0f67, 7); mov(memd[ss, ebp - 0x2c], 2);           /* mov dword [ebp-0x2c], 0x2 */
        l_0x1008_0f6e:
            ii(0x1008_0f6e, 7); mov(memd[ss, ebp - 0x30], 0);           /* mov dword [ebp-0x30], 0x0 */
            ii(0x1008_0f75, 2); jmp(0x1008_0f7d, 6); goto l_0x1008_0f7d; /* jmp 0x10080f7d */
        l_0x1008_0f77:
            ii(0x1008_0f77, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1008_0f7a, 3); inc(memd[ss, ebp - 0x30]);              /* inc dword [ebp-0x30] */
        l_0x1008_0f7d:
            ii(0x1008_0f7d, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1008_0f80, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x1008_0f87, 6); if(jge(0x1008_1049, 0xbc)) goto l_0x1008_1049; /* jge 0x10081049 */
            ii(0x1008_0f8d, 7); mov(memd[ss, ebp - 0x34], 0);           /* mov dword [ebp-0x34], 0x0 */
            ii(0x1008_0f94, 2); jmp(0x1008_0f9c, 6); goto l_0x1008_0f9c; /* jmp 0x10080f9c */
        l_0x1008_0f96:
            ii(0x1008_0f96, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1008_0f99, 3); inc(memd[ss, ebp - 0x34]);              /* inc dword [ebp-0x34] */
        l_0x1008_0f9c:
            ii(0x1008_0f9c, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1008_0f9f, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x1008_0fa6, 6); if(jge(0x1008_1044, 0x98)) goto l_0x1008_1044; /* jge 0x10081044 */
            ii(0x1008_0fac, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1008_0fb0, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1008_0fb3, 3); add(eax, memd[ss, ebp - 0x10]);         /* add eax, [ebp-0x10] */
            ii(0x1008_0fb6, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1008_0fba, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1008_0fbc, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_0fbe, 3); test(memb[ds, eax], 2);                 /* test byte [eax], 0x2 */
            ii(0x1008_0fc1, 2); if(jz(0x1008_0fda, 0x17)) goto l_0x1008_0fda; /* jz 0x10080fda */
            ii(0x1008_0fc3, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1008_0fc7, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1008_0fca, 3); add(eax, memd[ss, ebp - 0x10]);         /* add eax, [ebp-0x10] */
            ii(0x1008_0fcd, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1008_0fd1, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1008_0fd3, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_0fd5, 3); test(memb[ds, eax], 8);                 /* test byte [eax], 0x8 */
            ii(0x1008_0fd8, 2); if(jz(0x1008_0fdc, 2)) goto l_0x1008_0fdc; /* jz 0x10080fdc */
        l_0x1008_0fda:
            ii(0x1008_0fda, 2); jmp(0x1008_0ff6, 0x1a); goto l_0x1008_0ff6; /* jmp 0x10080ff6 */
        l_0x1008_0fdc:
            ii(0x1008_0fdc, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1008_0fe0, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1008_0fe4, 5); call(0x1007_3cfd, -0xd2ec);             /* call 0x10073cfd */
            ii(0x1008_0fe9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_0feb, 3); mov(dx, ax);                            /* mov dx, ax */
            ii(0x1008_0fee, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1008_0ff2, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_0ff4, 2); if(jz(0x1008_0ff8, 2)) goto l_0x1008_0ff8; /* jz 0x10080ff8 */
        l_0x1008_0ff6:
            ii(0x1008_0ff6, 2); jmp(0x1008_103f, 0x47); goto l_0x1008_103f; /* jmp 0x1008103f */
        l_0x1008_0ff8:
            ii(0x1008_0ff8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_0ffb, 4); mov(ax, memw[ds, eax + 0x1c]);          /* mov ax, [eax+0x1c] */
            ii(0x1008_0fff, 3); sub(eax, memd[ss, ebp - 0x34]);         /* sub eax, [ebp-0x34] */
            ii(0x1008_1002, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1008_1005, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_1008, 4); mov(ax, memw[ds, eax + 0x1a]);          /* mov ax, [eax+0x1a] */
            ii(0x1008_100c, 3); sub(eax, memd[ss, ebp - 0x30]);         /* sub eax, [ebp-0x30] */
            ii(0x1008_100f, 1); cwde();                                 /* cwde */
            ii(0x1008_1010, 5); call(0x100a_5f65, 0x2_4f50);            /* call 0x100a5f65 */
            ii(0x1008_1015, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x1008_1018, 4); cmp(memb[ss, ebp - 0x24], 0);           /* cmp byte [ebp-0x24], 0x0 */
            ii(0x1008_101c, 2); if(jz(0x1008_1027, 9)) goto l_0x1008_1027; /* jz 0x10081027 */
            ii(0x1008_101e, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1008_1021, 4); cmp(ax, memw[ss, ebp - 0x3c]);          /* cmp ax, [ebp-0x3c] */
            ii(0x1008_1025, 2); if(jge(0x1008_103f, 0x18)) goto l_0x1008_103f; /* jge 0x1008103f */
        l_0x1008_1027:
            ii(0x1008_1027, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1008_102a, 4); mov(memw[ss, ebp - 0x28], ax);          /* mov [ebp-0x28], ax */
            ii(0x1008_102e, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1008_1031, 4); mov(memw[ss, ebp - 0x26], ax);          /* mov [ebp-0x26], ax */
            ii(0x1008_1035, 4); mov(memb[ss, ebp - 0x24], 1);           /* mov byte [ebp-0x24], 0x1 */
            ii(0x1008_1039, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1008_103c, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
        l_0x1008_103f:
            ii(0x1008_103f, 5); jmp(0x1008_0f96, -0xae); goto l_0x1008_0f96; /* jmp 0x10080f96 */
        l_0x1008_1044:
            ii(0x1008_1044, 5); jmp(0x1008_0f77, -0xd2); goto l_0x1008_0f77; /* jmp 0x10080f77 */
        l_0x1008_1049:
            ii(0x1008_1049, 4); cmp(memb[ss, ebp - 0x24], 0);           /* cmp byte [ebp-0x24], 0x0 */
            ii(0x1008_104d, 6); if(jz(0x1008_10d4, 0x81)) goto l_0x1008_10d4; /* jz 0x100810d4 */
            ii(0x1008_1053, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x1008_1058, 5); call(Definitions.sys_new, 0xe_4da3);    /* call 0x10165e00 */
            ii(0x1008_105d, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x1008_1060, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x1008_1063, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x1008_1066, 4); cmp(memd[ss, ebp - 0x44], 0);           /* cmp dword [ebp-0x44], 0x0 */
            ii(0x1008_106a, 2); if(jz(0x1008_109f, 0x33)) goto l_0x1008_109f; /* jz 0x1008109f */
            ii(0x1008_106c, 5); mov(eax, 0x1008_0d75);                  /* mov eax, 0x10080d75 */
            ii(0x1008_1071, 1); push(eax);                              /* push eax */
            ii(0x1008_1072, 3); lea(edx, memd[ss, ebp - 0x28]);         /* lea edx, [ebp-0x28] */
            ii(0x1008_1075, 3); lea(eax, memd[ss, ebp - 0x48]);         /* lea eax, [ebp-0x48] */
            ii(0x1008_1078, 5); call(0x1007_5e64, -0xb219);             /* call 0x10075e64 */
            ii(0x1008_107d, 1); push(eax);                              /* push eax */
            ii(0x1008_107e, 5); mov(eax, 3);                            /* mov eax, 0x3 */
            ii(0x1008_1083, 1); push(eax);                              /* push eax */
            ii(0x1008_1084, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1008_1086, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1008_1089, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_108c, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x1008_108f, 5); call(0x100a_c220, 0x2_b18c);            /* call 0x100ac220 */
            ii(0x1008_1094, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
            ii(0x1008_1097, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x1008_109a, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x1008_109d, 2); jmp(0x1008_10a5, 6); goto l_0x1008_10a5; /* jmp 0x100810a5 */
        l_0x1008_109f:
            ii(0x1008_109f, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1008_10a2, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
        l_0x1008_10a5:
            ii(0x1008_10a5, 3); mov(edx, memd[ss, ebp - 0x50]);         /* mov edx, [ebp-0x50] */
            ii(0x1008_10a8, 3); lea(eax, memd[ss, ebp - 0x54]);         /* lea eax, [ebp-0x54] */
            ii(0x1008_10ab, 5); call(0x1008_b060, 0x9fb0);              /* call 0x1008b060 */
            ii(0x1008_10b0, 3); lea(eax, memd[ss, ebp - 0x54]);         /* lea eax, [ebp-0x54] */
            ii(0x1008_10b3, 5); call(0x1008_af84, 0x9ecc);              /* call 0x1008af84 */
            ii(0x1008_10b8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_10ba, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_10bf, 5); call(0x100a_4d50, 0x2_3c8c);            /* call 0x100a4d50 */
            ii(0x1008_10c4, 4); mov(memb[ss, ebp - 0xc], 1);            /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_10c8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_10ca, 3); lea(eax, memd[ss, ebp - 0x54]);         /* lea eax, [ebp-0x54] */
            ii(0x1008_10cd, 5); call(0x1008_8b7c, 0x7aaa);              /* call 0x10088b7c */
            ii(0x1008_10d2, 2); jmp(0x1008_10d8, 4); goto l_0x1008_10d8; /* jmp 0x100810d8 */
        l_0x1008_10d4:
            ii(0x1008_10d4, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
        l_0x1008_10d8:
            ii(0x1008_10d8, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1008_10db, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_10dd, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_10de, 1); pop(edi);                               /* pop edi */
            ii(0x1008_10df, 1); pop(esi);                               /* pop esi */
            ii(0x1008_10e0, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_10e1, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_10e2, 1); ret();                                  /* ret */
        }
    }
}
