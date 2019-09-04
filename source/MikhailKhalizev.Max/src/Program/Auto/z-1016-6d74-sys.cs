using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_6d74-ada2dd15")]
        public void /* sys */ Method_1016_6d74()
        {
            ii(0x1016_6d74, 1); push(esi);                              /* push esi */
            ii(0x1016_6d75, 1); push(edi);                              /* push edi */
            ii(0x1016_6d76, 1); push(ebp);                              /* push ebp */
            ii(0x1016_6d77, 3); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1016_6d7a, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1016_6d7c, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1016_6d7e, 4); mov(memd[ss, esp + 24], ecx);           /* mov [esp+0x18], ecx */
            ii(0x1016_6d82, 5); call(/* sys */ 0x1016_7dac, 0x1025);    /* call 0x10167dac */
            ii(0x1016_6d87, 6); mov(edx, memd[ds, 0x101b_ddbc]);        /* mov edx, [0x101bddbc] */
            ii(0x1016_6d8d, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_6d8f, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_6d91, 6); if(jz(0x1016_6ef9, 0x162)) goto l_0x1016_6ef9; /* jz 0x10166ef9 */
            ii(0x1016_6d97, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_6d99, 6); if(jz(0x1016_6ef9, 0x15a)) goto l_0x1016_6ef9; /* jz 0x10166ef9 */
            ii(0x1016_6d9f, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_6da1, 2); if(jnz(0x1016_6dbe, 0x1b)) goto l_0x1016_6dbe; /* jnz 0x10166dbe */
            ii(0x1016_6da3, 5); test(memb[ss, esp + 50], 4);            /* test byte [esp+0x32], 0x4 */
            ii(0x1016_6da8, 2); if(jz(0x1016_6db4, 0xa)) goto l_0x1016_6db4; /* jz 0x10166db4 */
            ii(0x1016_6daa, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_6dac, 6); call_abs(memd[ds, 0x101b_ddfc]);        /* call dword [0x101bddfc] */
            ii(0x1016_6db2, 2); jmp(0x1016_6dbc, 8); goto l_0x1016_6dbc; /* jmp 0x10166dbc */
        l_0x1016_6db4:
            ii(0x1016_6db4, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_6db6, 6); call_abs(memd[ds, 0x101b_ddf4]);        /* call dword [0x101bddf4] */
        l_0x1016_6dbc:
            ii(0x1016_6dbc, 2); mov(edi, eax);                          /* mov edi, eax */
        l_0x1016_6dbe:
            ii(0x1016_6dbe, 4); mov(eax, memd[ss, esp + 24]);           /* mov eax, [esp+0x18] */
            ii(0x1016_6dc2, 3); mov(ebx, memd[ds, esi + 24]);           /* mov ebx, [esi+0x18] */
            ii(0x1016_6dc5, 2); add(eax, edi);                          /* add eax, edi */
            ii(0x1016_6dc7, 2); cmp(eax, ebx);                          /* cmp eax, ebx */
            ii(0x1016_6dc9, 2); if(jle(0x1016_6dde, 0x13)) goto l_0x1016_6dde; /* jle 0x10166dde */
            ii(0x1016_6dcb, 5); test(memb[ss, esp + 51], 4);            /* test byte [esp+0x33], 0x4 */
            ii(0x1016_6dd0, 6); if(jz(0x1016_6ef9, 0x123)) goto l_0x1016_6ef9; /* jz 0x10166ef9 */
            ii(0x1016_6dd6, 4); mov(ecx, memd[ss, esp + 24]);           /* mov ecx, [esp+0x18] */
            ii(0x1016_6dda, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1016_6ddc, 2); sub(edi, ecx);                          /* sub edi, ecx */
        l_0x1016_6dde:
            ii(0x1016_6dde, 4); mov(edx, memd[ss, esp + 24]);           /* mov edx, [esp+0x18] */
            ii(0x1016_6de2, 3); mov(eax, memd[ds, esi + 44]);           /* mov eax, [esi+0x2c] */
            ii(0x1016_6de5, 3); mov(ebx, memd[ds, esi + 24]);           /* mov ebx, [esi+0x18] */
            ii(0x1016_6de8, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1016_6dea, 4); mov(eax, memd[ss, esp + 44]);           /* mov eax, [esp+0x2c] */
            ii(0x1016_6dee, 3); imul(eax, ebx);                         /* imul eax, ebx */
            ii(0x1016_6df1, 4); mov(ecx, memd[ss, esp + 44]);           /* mov ecx, [esp+0x2c] */
            ii(0x1016_6df5, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1016_6df7, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x1016_6dfd, 4); mov(memd[ss, esp + 16], edx);           /* mov [esp+0x10], edx */
            ii(0x1016_6e01, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1016_6e03, 3); cmp(eax, memd[ds, esi + 28]);           /* cmp eax, [esi+0x1c] */
            ii(0x1016_6e06, 6); if(jg(0x1016_6ef9, 0xed)) goto l_0x1016_6ef9; /* jg 0x10166ef9 */
            ii(0x1016_6e0c, 5); test(memb[ss, esp + 51], 2);            /* test byte [esp+0x33], 0x2 */
            ii(0x1016_6e11, 2); if(jnz(0x1016_6e6d, 0x5a)) goto l_0x1016_6e6d; /* jnz 0x10166e6d */
            ii(0x1016_6e13, 7); cmp(memd[ds, esi + 32], 0x100);         /* cmp dword [esi+0x20], 0x100 */
            ii(0x1016_6e1a, 2); if(jnz(0x1016_6e53, 0x37)) goto l_0x1016_6e53; /* jnz 0x10166e53 */
            ii(0x1016_6e1c, 6); mov(ecx, memd[ds, 0x101c_b2e0]);        /* mov ecx, [0x101cb2e0] */
            ii(0x1016_6e22, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1016_6e24, 2); if(jz(0x1016_6e53, 0x2d)) goto l_0x1016_6e53; /* jz 0x10166e53 */
            ii(0x1016_6e26, 4); mov(edx, memd[ss, esp + 44]);           /* mov edx, [esp+0x2c] */
            ii(0x1016_6e2a, 3); mov(eax, memd[ds, esi + 40]);           /* mov eax, [esi+0x28] */
            ii(0x1016_6e2d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_6e2f, 4); mov(ebx, memd[ss, esp + 24]);           /* mov ebx, [esp+0x18] */
            ii(0x1016_6e33, 1); push(eax);                              /* push eax */
            ii(0x1016_6e34, 3); mov(eax, memd[ds, esi + 36]);           /* mov eax, [esi+0x24] */
            ii(0x1016_6e37, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1016_6e39, 1); push(eax);                              /* push eax */
            ii(0x1016_6e3a, 1); push(ecx);                              /* push ecx */
            ii(0x1016_6e3b, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1016_6e3d, 3); mov(ecx, memd[ds, esi + 24]);           /* mov ecx, [esi+0x18] */
            ii(0x1016_6e40, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x1016_6e46, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_6e48, 4); mov(eax, memd[ss, esp + 28]);           /* mov eax, [esp+0x1c] */
            ii(0x1016_6e4c, 5); call(/* sys */ 0x1016_addc, 0x3f8b);    /* call 0x1016addc */
            ii(0x1016_6e51, 2); jmp(0x1016_6e6d, 0x1a); goto l_0x1016_6e6d; /* jmp 0x10166e6d */
        l_0x1016_6e53:
            ii(0x1016_6e53, 3); mov(eax, memd[ds, esi + 32]);           /* mov eax, [esi+0x20] */
            ii(0x1016_6e56, 1); push(eax);                              /* push eax */
            ii(0x1016_6e57, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1016_6e59, 3); mov(ecx, memd[ds, esi + 24]);           /* mov ecx, [esi+0x18] */
            ii(0x1016_6e5c, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x1016_6e62, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_6e64, 4); mov(eax, memd[ss, esp + 20]);           /* mov eax, [esp+0x14] */
            ii(0x1016_6e68, 5); call(/* sys */ 0x1016_ad78, 0x3f0b);    /* call 0x1016ad78 */
        l_0x1016_6e6d:
            ii(0x1016_6e6d, 5); test(memb[ss, esp + 49], 0xff);         /* test byte [esp+0x31], 0xff */
            ii(0x1016_6e72, 2); if(jz(0x1016_6e97, 0x23)) goto l_0x1016_6e97; /* jz 0x10166e97 */
            ii(0x1016_6e74, 4); mov(eax, memd[ss, esp + 48]);           /* mov eax, [esp+0x30] */
            ii(0x1016_6e78, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1016_6e7d, 7); mov(eax, memd[ds, eax * 4 + 0x101b_d9bc]); /* mov eax, [eax*4+0x101bd9bc] */
            ii(0x1016_6e84, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_6e86, 6); mov(dl, memb[ds, eax + 0x1020_0520]);   /* mov dl, [eax+0x10200520] */
            ii(0x1016_6e8c, 4); mov(eax, memd[ss, esp + 48]);           /* mov eax, [esp+0x30] */
            ii(0x1016_6e90, 3); xor(ax, ax);                            /* xor ax, ax */
            ii(0x1016_6e93, 2); or(eax, edx);                           /* or eax, edx */
            ii(0x1016_6e95, 2); jmp(0x1016_6e9b, 4); goto l_0x1016_6e9b; /* jmp 0x10166e9b */
        l_0x1016_6e97:
            ii(0x1016_6e97, 4); mov(eax, memd[ss, esp + 48]);           /* mov eax, [esp+0x30] */
        l_0x1016_6e9b:
            ii(0x1016_6e9b, 4); mov(memd[ss, esp + 20], eax);           /* mov [esp+0x14], eax */
            ii(0x1016_6e9f, 4); mov(eax, memd[ss, esp + 20]);           /* mov eax, [esp+0x14] */
            ii(0x1016_6ea3, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1016_6ea5, 2); mov(edx, ebp);                          /* mov edx, ebp */
            ii(0x1016_6ea7, 1); push(eax);                              /* push eax */
            ii(0x1016_6ea8, 3); mov(ecx, memd[ds, esi + 24]);           /* mov ecx, [esi+0x18] */
            ii(0x1016_6eab, 4); mov(eax, memd[ss, esp + 20]);           /* mov eax, [esp+0x14] */
            ii(0x1016_6eaf, 6); call_abs(memd[ds, 0x101b_ddec]);        /* call dword [0x101bddec] */
            ii(0x1016_6eb5, 5); test(memb[ss, esp + 23], 1);            /* test byte [esp+0x17], 0x1 */
            ii(0x1016_6eba, 2); if(jz(0x1016_6ef9, 0x3d)) goto l_0x1016_6ef9; /* jz 0x10166ef9 */
            ii(0x1016_6ebc, 4); mov(eax, memd[ss, esp + 24]);           /* mov eax, [esp+0x18] */
            ii(0x1016_6ec0, 3); mov(edx, memd[ds, esi + 8]);            /* mov edx, [esi+0x8] */
            ii(0x1016_6ec3, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_6ec5, 3); mov(memd[ss, esp], eax);                /* mov [esp], eax */
            ii(0x1016_6ec8, 4); mov(eax, memd[ss, esp + 44]);           /* mov eax, [esp+0x2c] */
            ii(0x1016_6ecc, 3); mov(ebx, memd[ds, esi + 12]);           /* mov ebx, [esi+0xc] */
            ii(0x1016_6ecf, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1016_6ed1, 4); mov(memd[ss, esp + 4], eax);            /* mov [esp+0x4], eax */
            ii(0x1016_6ed5, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_6ed8, 2); add(eax, edi);                          /* add eax, edi */
            ii(0x1016_6eda, 4); mov(memd[ss, esp + 8], eax);            /* mov [esp+0x8], eax */
            ii(0x1016_6ede, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x1016_6ee4, 4); mov(edx, memd[ss, esp + 4]);            /* mov edx, [esp+0x4] */
            ii(0x1016_6ee8, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1016_6eea, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_6eec, 4); mov(memd[ss, esp + 12], edx);           /* mov [esp+0xc], edx */
            ii(0x1016_6ef0, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_6ef2, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1016_6ef4, 5); call(/* sys */ 0x1016_7500, 0x607);     /* call 0x10167500 */
        l_0x1016_6ef9:
            ii(0x1016_6ef9, 3); add(esp, 0x1c);                         /* add esp, 0x1c */
            ii(0x1016_6efc, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_6efd, 1); pop(edi);                               /* pop edi */
            ii(0x1016_6efe, 1); pop(esi);                               /* pop esi */
            ii(0x1016_6eff, 3); ret(8);                                 /* ret 0x8 */
        }
    }
}
