using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_9cf0-18e2fe1d")]
        public void /* sys */ Method_1017_9cf0()
        {
            ii(0x1017_9cf0, 1); push(ebp);                              /* push ebp */
            ii(0x1017_9cf1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_9cf3, 1); push(esi);                              /* push esi */
            ii(0x1017_9cf4, 1); push(edi);                              /* push edi */
            ii(0x1017_9cf5, 3); sub(esp, 0x70);                         /* sub esp, 0x70 */
            ii(0x1017_9cf8, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x1017_9cfb, 2); mov(esi, ebx);                          /* mov esi, ebx */
            ii(0x1017_9cfd, 2); mov(edi, ecx);                          /* mov edi, ecx */
            ii(0x1017_9cff, 7); cmp(memd[ds, 0x101b_e418], -1 /* 0xff */); /* cmp dword [0x101be418], 0xffffffff */
            ii(0x1017_9d06, 2); if(jnz(0x1017_9d12, 0xa)) goto l_0x1017_9d12; /* jnz 0x10179d12 */
            ii(0x1017_9d08, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1017_9d0d, 5); jmp(0x1017_9f57, 0x245); goto l_0x1017_9f57; /* jmp 0x10179f57 */
        l_0x1017_9d12:
            ii(0x1017_9d12, 7); cmp(memd[ds, 0x101b_e41c], -1 /* 0xff */); /* cmp dword [0x101be41c], 0xffffffff */
            ii(0x1017_9d19, 2); if(jz(0x1017_9d20, 5)) goto l_0x1017_9d20; /* jz 0x10179d20 */
            ii(0x1017_9d1b, 5); call(Definitions.sys_timer_3, 0x1_3fa4); /* call 0x1018dcc4 */
        l_0x1017_9d20:
            ii(0x1017_9d20, 6); mov(ecx, memd[ds, 0x101b_e418]);        /* mov ecx, [0x101be418] */
            ii(0x1017_9d26, 3); cmp(ecx, -1 /* 0xff */);                /* cmp ecx, 0xffffffff */
            ii(0x1017_9d29, 2); if(jz(0x1017_9d47, 0x1c)) goto l_0x1017_9d47; /* jz 0x10179d47 */
            ii(0x1017_9d2b, 6); mov(edx, memd[ds, 0x101b_e434]);        /* mov edx, [0x101be434] */
            ii(0x1017_9d31, 3); cmp(edx, -1 /* 0xff */);                /* cmp edx, 0xffffffff */
            ii(0x1017_9d34, 2); if(jz(0x1017_9d47, 0x11)) goto l_0x1017_9d47; /* jz 0x10179d47 */
            ii(0x1017_9d36, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1017_9d38, 5); call(/* sys */ 0x1018_0376, 0x6639);    /* call 0x10180376 */
            ii(0x1017_9d3d, 10); mov(memd[ds, 0x101b_e434], 0xffff_ffff); /* mov dword [0x101be434], 0xffffffff */
        l_0x1017_9d47:
            ii(0x1017_9d47, 3); mov(eax, memd[ss, ebp + 8]);            /* mov eax, [ebp+0x8] */
            ii(0x1017_9d4a, 5); mov(memd[ds, 0x1020_9cfc], eax);        /* mov [0x10209cfc], eax */
            ii(0x1017_9d4f, 3); mov(eax, memd[ss, ebp + 12]);           /* mov eax, [ebp+0xc] */
            ii(0x1017_9d52, 6); mov(memd[ds, 0x1020_9d00], esi);        /* mov [0x10209d00], esi */
            ii(0x1017_9d58, 5); mov(memd[ds, 0x1020_9d0c], eax);        /* mov [0x10209d0c], eax */
            ii(0x1017_9d5d, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1017_9d5f, 2); if(jz(0x1017_9d7a, 0x19)) goto l_0x1017_9d7a; /* jz 0x10179d7a */
            ii(0x1017_9d61, 3); lea(ebx, memd[ss, ebp - 120]);          /* lea ebx, [ebp-0x78] */
            ii(0x1017_9d64, 5); mov(eax, memd[ds, 0x101b_e418]);        /* mov eax, [0x101be418] */
            ii(0x1017_9d69, 2); mov(ecx, ds);                           /* mov ecx, ds */
            ii(0x1017_9d6b, 5); call(/* sys */ 0x1019_45bc, 0x1_a84c);  /* call 0x101945bc */
            ii(0x1017_9d70, 4); cmp(memd[ss, ebp - 80], 0);             /* cmp dword [ebp-0x50], 0x0 */
            ii(0x1017_9d74, 2); if(jnz(0x1017_9d7a, 4)) goto l_0x1017_9d7a; /* jnz 0x10179d7a */
            ii(0x1017_9d76, 2); add(edi, edi);                          /* add edi, edi */
            ii(0x1017_9d78, 2); xor(esi, esi);                          /* xor esi, esi */
        l_0x1017_9d7a:
            ii(0x1017_9d7a, 5); mov(eax, 0x1020_9d24);                  /* mov eax, 0x10209d24 */
            ii(0x1017_9d7f, 5); mov(ebx, 0x74);                         /* mov ebx, 0x74 */
            ii(0x1017_9d84, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_9d86, 5); call(Definitions.sys_memset, -0x1_3fab); /* call 0x10165de0 */
            ii(0x1017_9d8b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_9d8d, 6); mov(memd[ds, 0x1020_9d30], ebx);        /* mov [0x10209d30], ebx */
            ii(0x1017_9d93, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1017_9d95, 3); setnz(al);                              /* setnz al */
            ii(0x1017_9d98, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_9d9d, 3); add(eax, 2);                            /* add eax, 0x2 */
            ii(0x1017_9da0, 5); mov(memd[ds, 0x1020_9d34], eax);        /* mov [0x10209d34], eax */
            ii(0x1017_9da5, 5); mov(eax, memd[ds, 0x101b_e43c]);        /* mov eax, [0x101be43c] */
            ii(0x1017_9daa, 5); mov(memd[ds, 0x1020_9d38], eax);        /* mov [0x10209d38], eax */
            ii(0x1017_9daf, 5); cmp(eax, 0x7fff);                       /* cmp eax, 0x7fff */
            ii(0x1017_9db4, 2); if(jz(0x1017_9dbd, 7)) goto l_0x1017_9dbd; /* jz 0x10179dbd */
            ii(0x1017_9db6, 7); or(memb[ds, 0x1020_9d4d], 1);           /* or byte [0x10209d4d], 0x1 */
        l_0x1017_9dbd:
            ii(0x1017_9dbd, 5); mov(eax, /* sys */ 0x1017_9b80);        /* mov eax, 0x10179b80 */
            ii(0x1017_9dc2, 6); mov(ebx, memd[ds, 0x101b_e418]);        /* mov ebx, [0x101be418] */
            ii(0x1017_9dc8, 5); mov(memd[ds, 0x1020_9d40], eax);        /* mov [0x10209d40], eax */
            ii(0x1017_9dcd, 3); imul(eax, ebx, 0x4c);                   /* imul eax, ebx, 0x4c */
            ii(0x1017_9dd0, 5); mov(ecx, 0x1000);                       /* mov ecx, 0x1000 */
            ii(0x1017_9dd5, 6); mov(memw[ds, 0x1020_9d44], cs);         /* mov [0x10209d44], cs */
            ii(0x1017_9ddb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_9ddd, 6); mov(memd[ds, 0x1020_9d3c], ecx);        /* mov [0x10209d3c], ecx */
            ii(0x1017_9de3, 6); mov(memd[ds, 0x1020_9d48], edx);        /* mov [0x10209d48], edx */
            ii(0x1017_9de9, 3); mov(ecx, memd[ss, ebp + 8]);            /* mov ecx, [ebp+0x8] */
            ii(0x1017_9dec, 6); mov(ebx, memd[ds, eax + 0x1020_bae8]);  /* mov ebx, [eax+0x1020bae8] */
            ii(0x1017_9df2, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_9df4, 2); if(jz(0x1017_9dfd, 7)) goto l_0x1017_9dfd; /* jz 0x10179dfd */
            ii(0x1017_9df6, 5); mov(eax, 0x80);                         /* mov eax, 0x80 */
            ii(0x1017_9dfb, 2); jmp(0x1017_9e02, 5); goto l_0x1017_9e02; /* jmp 0x10179e02 */
        l_0x1017_9dfd:
            ii(0x1017_9dfd, 5); mov(eax, 0x20);                         /* mov eax, 0x20 */
        l_0x1017_9e02:
            ii(0x1017_9e02, 6); or(memd[ds, 0x1020_9d4c], eax);         /* or [0x10209d4c], eax */
            ii(0x1017_9e08, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1017_9e0a, 2); if(jz(0x1017_9e13, 7)) goto l_0x1017_9e13; /* jz 0x10179e13 */
            ii(0x1017_9e0c, 7); or(memb[ds, 0x1020_9d4c], 0x10);        /* or byte [0x10209d4c], 0x10 */
        l_0x1017_9e13:
            ii(0x1017_9e13, 5); mov(eax, memd[ds, 0x101b_e418]);        /* mov eax, [0x101be418] */
            ii(0x1017_9e18, 7); cmp(edi, memd[ds, eax * 4 + 0x101c_02ec]); /* cmp edi, [eax*4+0x101c02ec] */
            ii(0x1017_9e1f, 2); if(jz(0x1017_9e3e, 0x1d)) goto l_0x1017_9e3e; /* jz 0x10179e3e */
            ii(0x1017_9e21, 6); mov(dh, memb[ds, 0x1020_9d4d]);         /* mov dh, [0x10209d4d] */
            ii(0x1017_9e27, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1017_9e29, 3); or(dh, 4);                              /* or dh, 0x4 */
            ii(0x1017_9e2c, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x1017_9e2f, 6); mov(memb[ds, 0x1020_9d4d], dh);         /* mov [0x10209d4d], dh */
            ii(0x1017_9e35, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_9e37, 2); div(ebx);                               /* div ebx */
            ii(0x1017_9e39, 5); mov(memd[ds, 0x1020_9d5c], eax);        /* mov [0x10209d5c], eax */
        l_0x1017_9e3e:
            ii(0x1017_9e3e, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1017_9e41, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1017_9e44, 5); mov(memd[ds, 0x1020_9d18], eax);        /* mov [0x10209d18], eax */
            ii(0x1017_9e49, 2); shr(eax, 1);                            /* shr eax, 1 */
            ii(0x1017_9e4b, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1017_9e4d, 5); mov(eax, 0x1020_9c50);                  /* mov eax, 0x10209c50 */
            ii(0x1017_9e52, 6); mov(memd[ds, 0x1020_9cf8], edx);        /* mov [0x10209cf8], edx */
            ii(0x1017_9e58, 5); call(/* sys */ 0x1017_95d0, -0x88d);    /* call 0x101795d0 */
            ii(0x1017_9e5d, 5); mov(memd[ds, 0x1020_9d08], eax);        /* mov [0x10209d08], eax */
            ii(0x1017_9e62, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_9e64, 6); if(jz(0x1017_9f57, 0xed)) goto l_0x1017_9f57; /* jz 0x10179f57 */
            ii(0x1017_9e6a, 5); mov(eax, 0x1020_9c50);                  /* mov eax, 0x10209c50 */
            ii(0x1017_9e6f, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1017_9e74, 5); call(/* sys */ 0x1017_9580, -0x8f9);    /* call 0x10179580 */
            ii(0x1017_9e79, 7); cmp(memd[ds, 0x101b_e440], 0);          /* cmp dword [0x101be440], 0x0 */
            ii(0x1017_9e80, 6); if(jz(0x1017_9f16, 0x90)) goto l_0x1017_9f16; /* jz 0x10179f16 */
            ii(0x1017_9e86, 5); mov(eax, /* sys */ 0x1017_9b80);        /* mov eax, 0x10179b80 */
            ii(0x1017_9e8b, 5); mov(ebx, 0x1000);                       /* mov ebx, 0x1000 */
            ii(0x1017_9e90, 2); mov(edx, cs);                           /* mov edx, cs */
            ii(0x1017_9e92, 5); call(/* sys */ 0x1019_44a0, 0x1_a609);  /* call 0x101944a0 */
            ii(0x1017_9e97, 5); mov(eax, 0x1020_9d24);                  /* mov eax, 0x10209d24 */
            ii(0x1017_9e9c, 5); mov(ebx, 0x74);                         /* mov ebx, 0x74 */
            ii(0x1017_9ea1, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1017_9ea3, 5); call(/* sys */ 0x1019_44a0, 0x1_a5f8);  /* call 0x101944a0 */
            ii(0x1017_9ea8, 5); mov(eax, 0x1020_9a70);                  /* mov eax, 0x10209a70 */
            ii(0x1017_9ead, 5); mov(ebx, 0x1e0);                        /* mov ebx, 0x1e0 */
            ii(0x1017_9eb2, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1017_9eb4, 5); call(/* sys */ 0x1019_44a0, 0x1_a5e7);  /* call 0x101944a0 */
            ii(0x1017_9eb9, 5); mov(eax, 0x1020_9da8);                  /* mov eax, 0x10209da8 */
            ii(0x1017_9ebe, 5); mov(ebx, 4);                            /* mov ebx, 0x4 */
            ii(0x1017_9ec3, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1017_9ec5, 5); call(/* sys */ 0x1019_44a0, 0x1_a5d6);  /* call 0x101944a0 */
            ii(0x1017_9eca, 5); mov(eax, 0x1020_9d1c);                  /* mov eax, 0x10209d1c */
            ii(0x1017_9ecf, 5); mov(ebx, 4);                            /* mov ebx, 0x4 */
            ii(0x1017_9ed4, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1017_9ed6, 5); call(/* sys */ 0x1019_44a0, 0x1_a5c5);  /* call 0x101944a0 */
            ii(0x1017_9edb, 5); mov(eax, 0x101b_e418);                  /* mov eax, 0x101be418 */
            ii(0x1017_9ee0, 5); mov(ebx, 4);                            /* mov ebx, 0x4 */
            ii(0x1017_9ee5, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1017_9ee7, 5); call(/* sys */ 0x1019_44a0, 0x1_a5b4);  /* call 0x101944a0 */
            ii(0x1017_9eec, 5); mov(eax, 0x101b_e434);                  /* mov eax, 0x101be434 */
            ii(0x1017_9ef1, 5); mov(ebx, 4);                            /* mov ebx, 0x4 */
            ii(0x1017_9ef6, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1017_9ef8, 5); call(/* sys */ 0x1019_44a0, 0x1_a5a3);  /* call 0x101944a0 */
            ii(0x1017_9efd, 5); mov(eax, 0x1020_9d9c);                  /* mov eax, 0x10209d9c */
            ii(0x1017_9f02, 5); mov(ebx, 4);                            /* mov ebx, 0x4 */
            ii(0x1017_9f07, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1017_9f09, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1017_9f0b, 5); call(/* sys */ 0x1019_44a0, 0x1_a590);  /* call 0x101944a0 */
            ii(0x1017_9f10, 6); mov(memd[ds, 0x101b_e440], edi);        /* mov [0x101be440], edi */
        l_0x1017_9f16:
            ii(0x1017_9f16, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_9f18, 5); mov(memd[ds, 0x1020_9d10], eax);        /* mov [0x10209d10], eax */
            ii(0x1017_9f1d, 5); mov(memd[ds, 0x1020_9d1c], eax);        /* mov [0x10209d1c], eax */
            ii(0x1017_9f22, 5); mov(memd[ds, 0x1020_9d14], eax);        /* mov [0x10209d14], eax */
            ii(0x1017_9f27, 5); mov(memd[ds, 0x1020_9d98], eax);        /* mov [0x10209d98], eax */
            ii(0x1017_9f2c, 5); mov(memd[ds, 0x1020_9dac], eax);        /* mov [0x10209dac], eax */
            ii(0x1017_9f31, 5); mov(memd[ds, 0x1020_9cf4], eax);        /* mov [0x10209cf4], eax */
            ii(0x1017_9f36, 5); mov(memd[ds, 0x101b_e438], eax);        /* mov [0x101be438], eax */
            ii(0x1017_9f3b, 5); mov(memd[ds, 0x1020_9da8], eax);        /* mov [0x10209da8], eax */
            ii(0x1017_9f40, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x1017_9f45, 5); mov(memd[ds, 0x1020_9da4], eax);        /* mov [0x10209da4], eax */
            ii(0x1017_9f4a, 5); mov(memd[ds, 0x1020_9da0], eax);        /* mov [0x10209da0], eax */
            ii(0x1017_9f4f, 6); mov(memd[ds, 0x1020_9d9c], ecx);        /* mov [0x10209d9c], ecx */
            ii(0x1017_9f55, 2); mov(eax, ecx);                          /* mov eax, ecx */
        l_0x1017_9f57:
            ii(0x1017_9f57, 3); lea(esp, memd[ss, ebp - 8]);            /* lea esp, [ebp-0x8] */
            ii(0x1017_9f5a, 1); pop(edi);                               /* pop edi */
            ii(0x1017_9f5b, 1); pop(esi);                               /* pop esi */
            ii(0x1017_9f5c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_9f5d, 3); ret(8);                                 /* ret 0x8 */
        }
    }
}
