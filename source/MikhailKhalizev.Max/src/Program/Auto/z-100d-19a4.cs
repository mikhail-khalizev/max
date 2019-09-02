using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_19a4-358ba21b")]
        public void Method_100d_19a4()
        {
            ii(0x100d_19a4, 5); push(0x8c);                             /* push 0x8c */
            ii(0x100d_19a9, 5); call(Definitions.sys_check_available_stack_size, 0x9_43a4); /* call 0x10165d52 */
            ii(0x100d_19ae, 1); push(ebx);                              /* push ebx */
            ii(0x100d_19af, 1); push(ecx);                              /* push ecx */
            ii(0x100d_19b0, 1); push(esi);                              /* push esi */
            ii(0x100d_19b1, 1); push(edi);                              /* push edi */
            ii(0x100d_19b2, 1); push(ebp);                              /* push ebp */
            ii(0x100d_19b3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_19b5, 6); sub(esp, 0x5c);                         /* sub esp, 0x5c */
            ii(0x100d_19bb, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_19be, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100d_19c1, 5); cmp(memw[ss, ebp - 4], -1 /* 0xff */);  /* cmp word [ebp-0x4], 0xffff */
            ii(0x100d_19c6, 6); if(jz(0x100d_20f7, 0x72b)) goto l_0x100d_20f7; /* jz 0x100d20f7 */
            ii(0x100d_19cc, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100d_19d0, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100d_19d3, 5); mov(edx, 0x101c_81c0);                  /* mov edx, 0x101c81c0 */
            ii(0x100d_19d8, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_19da, 3); mov(memd[ss, ebp - 0x14], edx);         /* mov [ebp-0x14], edx */
            ii(0x100d_19dd, 5); mov(ecx, 6);                            /* mov ecx, 0x6 */
            ii(0x100d_19e2, 3); lea(edi, memd[ss, ebp - 0x30]);         /* lea edi, [ebp-0x30] */
            ii(0x100d_19e5, 3); mov(esi, memd[ss, ebp - 8]);            /* mov esi, [ebp-0x8] */
            ii(0x100d_19e8, 3); lea(esi, memd[ds, esi + 0x17]);         /* lea esi, [esi+0x17] */
            ii(0x100d_19eb, 2); rep(() => movsd());                     /* rep movsd */
            ii(0x100d_19ed, 2); movsw();                                /* movsw */
            ii(0x100d_19ef, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_19f2, 3); mov(eax, memd[ds, eax + 0x25]);         /* mov eax, [eax+0x25] */
            ii(0x100d_19f5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_19f8, 3); imul(edx, eax, 0xd);                    /* imul edx, eax, 0xd */
            ii(0x100d_19fb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_19fe, 3); mov(eax, memd[ds, eax + 0x2d]);         /* mov eax, [eax+0x2d] */
            ii(0x100d_1a01, 3); add(eax, 0xb);                          /* add eax, 0xb */
            ii(0x100d_1a04, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_1a06, 3); mov(memd[ss, ebp - 0x1a], eax);         /* mov [ebp-0x1a], eax */
            ii(0x100d_1a09, 5); call(0x100d_533c, 0x392e);              /* call 0x100d533c */
            ii(0x100d_1a0e, 1); cwde();                                 /* cwde */
            ii(0x100d_1a0f, 1); push(eax);                              /* push eax */
            ii(0x100d_1a10, 5); call(0x100d_5360, 0x394b);              /* call 0x100d5360 */
            ii(0x100d_1a15, 1); cwde();                                 /* cwde */
            ii(0x100d_1a16, 1); push(eax);                              /* push eax */
            ii(0x100d_1a17, 5); call(0x100d_5384, 0x3968);              /* call 0x100d5384 */
            ii(0x100d_1a1c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100d_1a21, 1); push(eax);                              /* push eax */
            ii(0x100d_1a22, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100d_1a24, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1a27, 3); mov(ebx, memd[ds, eax + 0x25]);         /* mov ebx, [eax+0x25] */
            ii(0x100d_1a2a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_1a2d, 3); lea(edx, memd[ss, ebp - 0x30]);         /* lea edx, [ebp-0x30] */
            ii(0x100d_1a30, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_1a33, 3); mov(eax, memd[ds, eax + 0xa]);          /* mov eax, [eax+0xa] */
            ii(0x100d_1a36, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_1a39, 5); call(0x100e_8c51, 0x1_7213);            /* call 0x100e8c51 */
            ii(0x100d_1a3e, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x100d_1a41, 2); if(jnz(0x100d_1a8b, 0x48)) goto l_0x100d_1a8b; /* jnz 0x100d1a8b */
            ii(0x100d_1a43, 2); push(0);                                /* push 0x0 */
            ii(0x100d_1a45, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1a48, 3); mov(ecx, memd[ds, eax + 0x25]);         /* mov ecx, [eax+0x25] */
            ii(0x100d_1a4b, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100d_1a4e, 5); mov(ebx, 0xf0);                         /* mov ebx, 0xf0 */
            ii(0x100d_1a53, 5); mov(edx, 0x12c);                        /* mov edx, 0x12c */
            ii(0x100d_1a58, 3); mov(eax, memd[ss, ebp - 0x1a]);         /* mov eax, [ebp-0x1a] */
            ii(0x100d_1a5b, 5); call(/* sys */ 0x1016_ad78, 0x9_9318);  /* call 0x1016ad78 */
            ii(0x100d_1a60, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_1a62, 1); push(eax);                              /* push eax */
            ii(0x100d_1a63, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_1a65, 1); push(eax);                              /* push eax */
            ii(0x100d_1a66, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x100d_1a6b, 1); push(eax);                              /* push eax */
            ii(0x100d_1a6c, 5); mov(ecx, 0x10);                         /* mov ecx, 0x10 */
            ii(0x100d_1a71, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1a74, 3); mov(ebx, memd[ds, eax + 0x25]);         /* mov ebx, [eax+0x25] */
            ii(0x100d_1a77, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_1a7a, 3); lea(edx, memd[ss, ebp - 0x30]);         /* lea edx, [ebp-0x30] */
            ii(0x100d_1a7d, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_1a80, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x100d_1a83, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_1a86, 5); call(0x100f_04d8, 0x1_ea4d);            /* call 0x100f04d8 */
        l_0x100d_1a8b:
            ii(0x100d_1a8b, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_1a8e, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100d_1a91, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1a94, 3); mov(eax, memd[ds, eax + 0x6a]);         /* mov eax, [eax+0x6a] */
            ii(0x100d_1a97, 5); call(0x100d_7f6c, 0x64d0);              /* call 0x100d7f6c */
            ii(0x100d_1a9c, 5); mov(eax, 0x271);                        /* mov eax, 0x271 */
            ii(0x100d_1aa1, 1); push(eax);                              /* push eax */
            ii(0x100d_1aa2, 5); mov(eax, 0x270);                        /* mov eax, 0x270 */
            ii(0x100d_1aa7, 1); push(eax);                              /* push eax */
            ii(0x100d_1aa8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1aab, 3); mov(eax, memd[ds, eax + 0x6a]);         /* mov eax, [eax+0x6a] */
            ii(0x100d_1aae, 5); call(0x100d_4f58, 0x34a5);              /* call 0x100d4f58 */
            ii(0x100d_1ab3, 1); cwde();                                 /* cwde */
            ii(0x100d_1ab4, 1); push(eax);                              /* push eax */
            ii(0x100d_1ab5, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100d_1ab9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1abc, 3); mov(eax, memd[ds, eax + 0x31]);         /* mov eax, [eax+0x31] */
            ii(0x100d_1abf, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x100d_1ac2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100d_1ac7, 6); imul(ebx, eax, 0x247);                  /* imul ebx, eax, 0x247 */
            ii(0x100d_1acd, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x100d_1ad2, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100d_1ad4, 5); call(0x100d_fd2c, 0xe253);              /* call 0x100dfd2c */
            ii(0x100d_1ad9, 1); push(eax);                              /* push eax */
            ii(0x100d_1ada, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1add, 3); mov(eax, memd[ds, eax + 0x31]);         /* mov eax, [eax+0x31] */
            ii(0x100d_1ae0, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x100d_1ae3, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100d_1ae5, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_1ae8, 4); movsx(ebx, memw[ss, ebp - 4]);          /* movsx ebx, word [ebp-0x4] */
            ii(0x100d_1aec, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_1aef, 3); mov(edx, memd[ds, edx + 0x25]);         /* mov edx, [edx+0x25] */
            ii(0x100d_1af2, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_1af5, 3); mov(esi, memd[ss, ebp - 8]);            /* mov esi, [ebp-0x8] */
            ii(0x100d_1af8, 3); mov(esi, memd[ds, esi + 0x25]);         /* mov esi, [esi+0x25] */
            ii(0x100d_1afb, 3); sar(esi, 0x10);                         /* sar esi, 0x10 */
            ii(0x100d_1afe, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1b01, 3); mov(eax, memd[ds, eax + 0x6a]);         /* mov eax, [eax+0x6a] */
            ii(0x100d_1b04, 5); call(0x100d_4ebc, 0x33b3);              /* call 0x100d4ebc */
            ii(0x100d_1b09, 1); cwde();                                 /* cwde */
            ii(0x100d_1b0a, 3); imul(esi, eax);                         /* imul esi, eax */
            ii(0x100d_1b0d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1b10, 3); mov(eax, memd[ds, eax + 0x6a]);         /* mov eax, [eax+0x6a] */
            ii(0x100d_1b13, 5); call(0x100d_4ef0, 0x33d8);              /* call 0x100d4ef0 */
            ii(0x100d_1b18, 1); cwde();                                 /* cwde */
            ii(0x100d_1b19, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x100d_1b1c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1b1f, 3); mov(eax, memd[ds, eax + 0x2d]);         /* mov eax, [eax+0x2d] */
            ii(0x100d_1b22, 3); add(eax, memd[ss, ebp - 0x34]);         /* add eax, [ebp-0x34] */
            ii(0x100d_1b25, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x100d_1b27, 5); call(0x1014_018f, 0x6_e663);            /* call 0x1014018f */
            ii(0x100d_1b2c, 5); cmp(memw[ss, ebp - 4], -1 /* 0xff */);  /* cmp word [ebp-0x4], 0xffff */
            ii(0x100d_1b31, 2); if(jz(0x100d_1b3c, 9)) goto l_0x100d_1b3c; /* jz 0x100d1b3c */
            ii(0x100d_1b33, 7); cmp(memb[ds, 0x101b_7ed0], 0);          /* cmp byte [0x101b7ed0], 0x0 */
            ii(0x100d_1b3a, 2); if(jnz(0x100d_1b3e, 2)) goto l_0x100d_1b3e; /* jnz 0x100d1b3e */
        l_0x100d_1b3c:
            ii(0x100d_1b3c, 2); jmp(0x100d_1b84, 0x46); goto l_0x100d_1b84; /* jmp 0x100d1b84 */
        l_0x100d_1b3e:
            ii(0x100d_1b3e, 5); mov(eax, 5);                            /* mov eax, 0x5 */
            ii(0x100d_1b43, 5); call(/* sys */ 0x1016_a24c, 0x9_8704);  /* call 0x1016a24c */
            ii(0x100d_1b48, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_1b4a, 1); push(eax);                              /* push eax */
            ii(0x100d_1b4b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_1b4d, 1); push(eax);                              /* push eax */
            ii(0x100d_1b4e, 5); push(0x1_00a2);                         /* push 0x100a2 */
            ii(0x100d_1b53, 5); mov(eax, 0xe6);                         /* mov eax, 0xe6 */
            ii(0x100d_1b58, 1); push(eax);                              /* push eax */
            ii(0x100d_1b59, 5); mov(eax, 0x122);                        /* mov eax, 0x122 */
            ii(0x100d_1b5e, 1); push(eax);                              /* push eax */
            ii(0x100d_1b5f, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x100d_1b64, 1); push(eax);                              /* push eax */
            ii(0x100d_1b65, 5); mov(ecx, 0x10);                         /* mov ecx, 0x10 */
            ii(0x100d_1b6a, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_1b6d, 3); mov(ebx, memd[ds, eax + 0x1f]);         /* mov ebx, [eax+0x1f] */
            ii(0x100d_1b70, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1b73, 3); mov(edx, memd[ds, eax + 0x25]);         /* mov edx, [eax+0x25] */
            ii(0x100d_1b76, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_1b79, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1b7c, 3); mov(eax, memd[ds, eax + 0x2d]);         /* mov eax, [eax+0x2d] */
            ii(0x100d_1b7f, 5); call(0x100e_9ae5, 0x1_7f61);            /* call 0x100e9ae5 */
        l_0x100d_1b84:
            ii(0x100d_1b84, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1b87, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x100d_1b8a, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x100d_1b8d, 3); mov(ebx, memd[ds, eax + 0x13]);         /* mov ebx, [eax+0x13] */
            ii(0x100d_1b90, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100d_1b94, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x100d_1b97, 3); call_abs(memd[ds, ebx + 0x10]);         /* call dword [ebx+0x10] */
            ii(0x100d_1b9a, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x100d_1b9d, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_1ba0, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100d_1ba3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1ba6, 3); mov(eax, memd[ds, eax + 0x6e]);         /* mov eax, [eax+0x6e] */
            ii(0x100d_1ba9, 5); call(0x100d_7f6c, 0x63be);              /* call 0x100d7f6c */
            ii(0x100d_1bae, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_1bb1, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100d_1bb4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1bb7, 3); mov(eax, memd[ds, eax + 0x72]);         /* mov eax, [eax+0x72] */
            ii(0x100d_1bba, 5); call(0x100d_7f6c, 0x63ad);              /* call 0x100d7f6c */
            ii(0x100d_1bbf, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_1bc2, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100d_1bc5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1bc8, 3); mov(eax, memd[ds, eax + 0x76]);         /* mov eax, [eax+0x76] */
            ii(0x100d_1bcb, 5); call(0x100d_7f6c, 0x639c);              /* call 0x100d7f6c */
            ii(0x100d_1bd0, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_1bd3, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100d_1bd6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1bd9, 3); mov(eax, memd[ds, eax + 0x7a]);         /* mov eax, [eax+0x7a] */
            ii(0x100d_1bdc, 5); call(0x100d_7f6c, 0x638b);              /* call 0x100d7f6c */
            ii(0x100d_1be1, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_1be4, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100d_1be7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1bea, 3); mov(eax, memd[ds, eax + 0x7e]);         /* mov eax, [eax+0x7e] */
            ii(0x100d_1bed, 5); call(0x100d_7f6c, 0x637a);              /* call 0x100d7f6c */
            ii(0x100d_1bf2, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_1bf5, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100d_1bf8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1bfb, 6); mov(eax, memd[ds, eax + 0x82]);         /* mov eax, [eax+0x82] */
            ii(0x100d_1c01, 5); call(0x100d_7f6c, 0x6366);              /* call 0x100d7f6c */
            ii(0x100d_1c06, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x100d_1c09, 3); mov(ebx, memd[ds, ebx + 0x31]);         /* mov ebx, [ebx+0x31] */
            ii(0x100d_1c0c, 3); mov(ebx, memd[ds, ebx + 0x50]);         /* mov ebx, [ebx+0x50] */
            ii(0x100d_1c0f, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_1c12, 4); movsx(edx, memw[ss, ebp - 0x3c]);       /* movsx edx, word [ebp-0x3c] */
            ii(0x100d_1c16, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1c19, 3); mov(eax, memd[ds, eax + 0x31]);         /* mov eax, [eax+0x31] */
            ii(0x100d_1c1c, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_1c1f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_1c22, 5); call(0x100d_4c69, 0x3042);              /* call 0x100d4c69 */
            ii(0x100d_1c27, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_1c2a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1c2d, 4); mov(ax, memw[ds, eax + 0x38]);          /* mov ax, [eax+0x38] */
            ii(0x100d_1c31, 4); cmp(ax, memw[ss, ebp - 0x10]);          /* cmp ax, [ebp-0x10] */
            ii(0x100d_1c35, 6); if(jle(0x100d_1cc9, 0x8e)) goto l_0x100d_1cc9; /* jle 0x100d1cc9 */
            ii(0x100d_1c3b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_1c3d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1c40, 3); mov(eax, memd[ds, eax + 0x62]);         /* mov eax, [eax+0x62] */
            ii(0x100d_1c43, 5); call(0x100c_fb73, -0x20d5);             /* call 0x100cfb73 */
            ii(0x100d_1c48, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_1c4a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1c4d, 3); mov(eax, memd[ds, eax + 0x66]);         /* mov eax, [eax+0x66] */
            ii(0x100d_1c50, 5); call(0x100c_fb73, -0x20e2);             /* call 0x100cfb73 */
            ii(0x100d_1c55, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_1c58, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_1c5b, 4); mov(memw[ds, edx + 0x38], ax);          /* mov [edx+0x38], ax */
            ii(0x100d_1c5f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1c62, 4); mov(ax, memw[ds, eax + 0x38]);          /* mov ax, [eax+0x38] */
            ii(0x100d_1c66, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x100d_1c69, 2); jmp(0x100d_1ca3, 0x38); goto l_0x100d_1ca3; /* jmp 0x100d1ca3 */
        l_0x100d_1c6b:
            ii(0x100d_1c6b, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100d_1c70, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1c73, 3); mov(eax, memd[ds, eax + 0x5e]);         /* mov eax, [eax+0x5e] */
            ii(0x100d_1c76, 5); call(0x100c_fb73, -0x2108);             /* call 0x100cfb73 */
            ii(0x100d_1c7b, 2); jmp(0x100d_1cc9, 0x4c); goto l_0x100d_1cc9; /* jmp 0x100d1cc9 */
        l_0x100d_1c7d:
            ii(0x100d_1c7d, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100d_1c82, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1c85, 3); mov(eax, memd[ds, eax + 0x62]);         /* mov eax, [eax+0x62] */
            ii(0x100d_1c88, 5); call(0x100c_fb73, -0x211a);             /* call 0x100cfb73 */
            ii(0x100d_1c8d, 2); jmp(0x100d_1cc9, 0x3a); goto l_0x100d_1cc9; /* jmp 0x100d1cc9 */
        l_0x100d_1c8f:
            ii(0x100d_1c8f, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100d_1c94, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1c97, 3); mov(eax, memd[ds, eax + 0x66]);         /* mov eax, [eax+0x66] */
            ii(0x100d_1c9a, 5); call(0x100c_fb73, -0x212c);             /* call 0x100cfb73 */
            ii(0x100d_1c9f, 2); jmp(0x100d_1cc9, 0x28); goto l_0x100d_1cc9; /* jmp 0x100d1cc9 */
        l_0x100d_1ca1:
            ii(0x100d_1ca1, 2); jmp(0x100d_1cc9, 0x26); goto l_0x100d_1cc9; /* jmp 0x100d1cc9 */
        l_0x100d_1ca3:
            ii(0x100d_1ca3, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x100d_1ca6, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x100d_1ca9, 5); cmp(memw[ss, ebp - 0x44], 2);           /* cmp word [ebp-0x44], 0x2 */
            ii(0x100d_1cae, 2); if(jb(0x100d_1cc0, 0x10)) goto l_0x100d_1cc0; /* jb 0x100d1cc0 */
            ii(0x100d_1cb0, 5); cmp(memw[ss, ebp - 0x44], 2);           /* cmp word [ebp-0x44], 0x2 */
            ii(0x100d_1cb5, 2); if(jbe(0x100d_1c7d, -0x3a)) goto l_0x100d_1c7d; /* jbe 0x100d1c7d */
            ii(0x100d_1cb7, 5); cmp(memw[ss, ebp - 0x44], 4);           /* cmp word [ebp-0x44], 0x4 */
            ii(0x100d_1cbc, 2); if(jz(0x100d_1c8f, -0x2f)) goto l_0x100d_1c8f; /* jz 0x100d1c8f */
            ii(0x100d_1cbe, 2); jmp(0x100d_1ca1, -0x1f); goto l_0x100d_1ca1; /* jmp 0x100d1ca1 */
        l_0x100d_1cc0:
            ii(0x100d_1cc0, 5); cmp(memw[ss, ebp - 0x44], 1);           /* cmp word [ebp-0x44], 0x1 */
            ii(0x100d_1cc5, 2); if(jz(0x100d_1c6b, -0x5c)) goto l_0x100d_1c6b; /* jz 0x100d1c6b */
            ii(0x100d_1cc7, 2); jmp(0x100d_1ca1, -0x28); goto l_0x100d_1ca1; /* jmp 0x100d1ca1 */
        l_0x100d_1cc9:
            ii(0x100d_1cc9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1ccc, 3); mov(eax, memd[ds, eax + 0x36]);         /* mov eax, [eax+0x36] */
            ii(0x100d_1ccf, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_1cd2, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x100d_1cd5, 2); if(jnz(0x100d_1cdd, 6)) goto l_0x100d_1cdd; /* jnz 0x100d1cdd */
            ii(0x100d_1cd7, 4); mov(memb[ss, ebp - 0x48], 2);           /* mov byte [ebp-0x48], 0x2 */
            ii(0x100d_1cdb, 2); jmp(0x100d_1ce1, 4); goto l_0x100d_1ce1; /* jmp 0x100d1ce1 */
        l_0x100d_1cdd:
            ii(0x100d_1cdd, 4); mov(memb[ss, ebp - 0x48], 0xa2);        /* mov byte [ebp-0x48], 0xa2 */
        l_0x100d_1ce1:
            ii(0x100d_1ce1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_1ce3, 3); mov(al, memb[ss, ebp - 0x48]);          /* mov al, [ebp-0x48] */
            ii(0x100d_1ce6, 1); push(eax);                              /* push eax */
            ii(0x100d_1ce7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1cea, 3); mov(ecx, memd[ds, eax + 0x25]);         /* mov ecx, [eax+0x25] */
            ii(0x100d_1ced, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100d_1cf0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1cf3, 3); mov(eax, memd[ds, eax + 0x6e]);         /* mov eax, [eax+0x6e] */
            ii(0x100d_1cf6, 5); call(0x100d_4f58, 0x325d);              /* call 0x100d4f58 */
            ii(0x100d_1cfb, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_1cfe, 4); movsx(edx, memw[ss, ebp - 0x3c]);       /* movsx edx, word [ebp-0x3c] */
            ii(0x100d_1d02, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1d05, 3); mov(eax, memd[ds, eax + 0x6e]);         /* mov eax, [eax+0x6e] */
            ii(0x100d_1d08, 5); call(0x100d_4ef0, 0x31e3);              /* call 0x100d4ef0 */
            ii(0x100d_1d0d, 3); movsx(esi, ax);                         /* movsx esi, ax */
            ii(0x100d_1d10, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1d13, 3); mov(eax, memd[ds, eax + 0x2d]);         /* mov eax, [eax+0x2d] */
            ii(0x100d_1d16, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x100d_1d18, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1d1b, 3); mov(eax, memd[ds, eax + 0x6e]);         /* mov eax, [eax+0x6e] */
            ii(0x100d_1d1e, 5); call(0x100d_4f58, 0x3235);              /* call 0x100d4f58 */
            ii(0x100d_1d23, 1); cwde();                                 /* cwde */
            ii(0x100d_1d24, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x100d_1d26, 3); mov(memd[ss, ebp - 0x34], esi);         /* mov [ebp-0x34], esi */
            ii(0x100d_1d29, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1d2c, 3); mov(esi, memd[ds, eax + 0x25]);         /* mov esi, [eax+0x25] */
            ii(0x100d_1d2f, 3); sar(esi, 0x10);                         /* sar esi, 0x10 */
            ii(0x100d_1d32, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1d35, 3); mov(eax, memd[ds, eax + 0x6e]);         /* mov eax, [eax+0x6e] */
            ii(0x100d_1d38, 5); call(0x100d_4ebc, 0x317f);              /* call 0x100d4ebc */
            ii(0x100d_1d3d, 1); cwde();                                 /* cwde */
            ii(0x100d_1d3e, 3); imul(eax, esi);                         /* imul eax, esi */
            ii(0x100d_1d41, 3); mov(esi, memd[ss, ebp - 0x34]);         /* mov esi, [ebp-0x34] */
            ii(0x100d_1d44, 1); dec(esi);                               /* dec esi */
            ii(0x100d_1d45, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x100d_1d47, 5); call(0x1012_b658, 0x5_990c);            /* call 0x1012b658 */
            ii(0x100d_1d4c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1d4f, 3); mov(eax, memd[ds, eax + 0x36]);         /* mov eax, [eax+0x36] */
            ii(0x100d_1d52, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_1d55, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x100d_1d58, 2); if(jnz(0x100d_1d60, 6)) goto l_0x100d_1d60; /* jnz 0x100d1d60 */
            ii(0x100d_1d5a, 4); mov(memb[ss, ebp - 0x4c], 2);           /* mov byte [ebp-0x4c], 0x2 */
            ii(0x100d_1d5e, 2); jmp(0x100d_1d64, 4); goto l_0x100d_1d64; /* jmp 0x100d1d64 */
        l_0x100d_1d60:
            ii(0x100d_1d60, 4); mov(memb[ss, ebp - 0x4c], 0xa2);        /* mov byte [ebp-0x4c], 0xa2 */
        l_0x100d_1d64:
            ii(0x100d_1d64, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_1d66, 3); mov(al, memb[ss, ebp - 0x4c]);          /* mov al, [ebp-0x4c] */
            ii(0x100d_1d69, 1); push(eax);                              /* push eax */
            ii(0x100d_1d6a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1d6d, 3); mov(ecx, memd[ds, eax + 0x25]);         /* mov ecx, [eax+0x25] */
            ii(0x100d_1d70, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100d_1d73, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1d76, 3); mov(eax, memd[ds, eax + 0x72]);         /* mov eax, [eax+0x72] */
            ii(0x100d_1d79, 5); call(0x100d_4f58, 0x31da);              /* call 0x100d4f58 */
            ii(0x100d_1d7e, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_1d81, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100d_1d86, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1d89, 3); mov(eax, memd[ds, eax + 0x31]);         /* mov eax, [eax+0x31] */
            ii(0x100d_1d8c, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_1d8f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_1d92, 5); call(0x1007_1e00, -0x5_ff97);           /* call 0x10071e00 */
            ii(0x100d_1d97, 4); imul(eax, memd[ss, ebp - 0x3c]);        /* imul eax, [ebp-0x3c] */
            ii(0x100d_1d9b, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_1d9e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1da1, 3); mov(eax, memd[ds, eax + 0x72]);         /* mov eax, [eax+0x72] */
            ii(0x100d_1da4, 5); call(0x100d_4ef0, 0x3147);              /* call 0x100d4ef0 */
            ii(0x100d_1da9, 1); cwde();                                 /* cwde */
            ii(0x100d_1daa, 3); mov(esi, memd[ss, ebp - 8]);            /* mov esi, [ebp-0x8] */
            ii(0x100d_1dad, 3); mov(esi, memd[ds, esi + 0x2d]);         /* mov esi, [esi+0x2d] */
            ii(0x100d_1db0, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x100d_1db2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1db5, 3); mov(eax, memd[ds, eax + 0x72]);         /* mov eax, [eax+0x72] */
            ii(0x100d_1db8, 5); call(0x100d_4f58, 0x319b);              /* call 0x100d4f58 */
            ii(0x100d_1dbd, 1); cwde();                                 /* cwde */
            ii(0x100d_1dbe, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x100d_1dc0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1dc3, 3); mov(eax, memd[ds, eax + 0x25]);         /* mov eax, [eax+0x25] */
            ii(0x100d_1dc6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_1dc9, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x100d_1dcc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1dcf, 3); mov(eax, memd[ds, eax + 0x72]);         /* mov eax, [eax+0x72] */
            ii(0x100d_1dd2, 5); call(0x100d_4ebc, 0x30e5);              /* call 0x100d4ebc */
            ii(0x100d_1dd7, 1); cwde();                                 /* cwde */
            ii(0x100d_1dd8, 3); mov(edi, memd[ss, ebp - 0x34]);         /* mov edi, [ebp-0x34] */
            ii(0x100d_1ddb, 3); imul(edi, eax);                         /* imul edi, eax */
            ii(0x100d_1dde, 3); mov(memd[ss, ebp - 0x34], edi);         /* mov [ebp-0x34], edi */
            ii(0x100d_1de1, 3); lea(eax, memd[ds, esi - 1]);            /* lea eax, [esi-0x1] */
            ii(0x100d_1de4, 3); add(eax, memd[ss, ebp - 0x34]);         /* add eax, [ebp-0x34] */
            ii(0x100d_1de7, 5); call(0x1012_b658, 0x5_986c);            /* call 0x1012b658 */
            ii(0x100d_1dec, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1def, 3); mov(eax, memd[ds, eax + 0x31]);         /* mov eax, [eax+0x31] */
            ii(0x100d_1df2, 5); cmp(memw[ds, eax + 8], 0x20);           /* cmp word [eax+0x8], 0x20 */
            ii(0x100d_1df7, 2); if(jnz(0x100d_1e2a, 0x31)) goto l_0x100d_1e2a; /* jnz 0x100d1e2a */
            ii(0x100d_1df9, 5); call(0x100d_51e4, 0x33e6);              /* call 0x100d51e4 */
            ii(0x100d_1dfe, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_1e00, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_1e02, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_1e04, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1e07, 3); mov(eax, memd[ds, eax + 0x62]);         /* mov eax, [eax+0x62] */
            ii(0x100d_1e0a, 5); call(0x100c_fa7c, -0x2393);             /* call 0x100cfa7c */
            ii(0x100d_1e0f, 5); call(0x100d_51e4, 0x33d0);              /* call 0x100d51e4 */
            ii(0x100d_1e14, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_1e16, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_1e18, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_1e1a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1e1d, 3); mov(eax, memd[ds, eax + 0x66]);         /* mov eax, [eax+0x66] */
            ii(0x100d_1e20, 5); call(0x100c_fa7c, -0x23a9);             /* call 0x100cfa7c */
            ii(0x100d_1e25, 5); jmp(0x100d_20ec, 0x2c2); goto l_0x100d_20ec; /* jmp 0x100d20ec */
        l_0x100d_1e2a:
            ii(0x100d_1e2a, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100d_1e2e, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x100d_1e31, 2); if(jge(0x100d_1e4e, 0x1b)) goto l_0x100d_1e4e; /* jge 0x100d1e4e */
            ii(0x100d_1e33, 5); call(0x100d_51e4, 0x33ac);              /* call 0x100d51e4 */
            ii(0x100d_1e38, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_1e3a, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_1e3c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_1e3e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1e41, 3); mov(eax, memd[ds, eax + 0x62]);         /* mov eax, [eax+0x62] */
            ii(0x100d_1e44, 5); call(0x100c_fa7c, -0x23cd);             /* call 0x100cfa7c */
            ii(0x100d_1e49, 5); jmp(0x100d_1f85, 0x137); goto l_0x100d_1f85; /* jmp 0x100d1f85 */
        l_0x100d_1e4e:
            ii(0x100d_1e4e, 5); call(0x100d_51e4, 0x3391);              /* call 0x100d51e4 */
            ii(0x100d_1e53, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_1e55, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_1e57, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100d_1e5c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1e5f, 3); mov(eax, memd[ds, eax + 0x62]);         /* mov eax, [eax+0x62] */
            ii(0x100d_1e62, 5); call(0x100c_fa7c, -0x23eb);             /* call 0x100cfa7c */
            ii(0x100d_1e67, 3); lea(ecx, memd[ss, ebp - 0x3c]);         /* lea ecx, [ebp-0x3c] */
            ii(0x100d_1e6a, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x100d_1e6f, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100d_1e73, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1e76, 3); mov(eax, memd[ds, eax + 0x31]);         /* mov eax, [eax+0x31] */
            ii(0x100d_1e79, 5); call(0x1015_4f88, 0x8_310a);            /* call 0x10154f88 */
            ii(0x100d_1e7e, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100d_1e81, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1e84, 3); mov(eax, memd[ds, eax + 0x36]);         /* mov eax, [eax+0x36] */
            ii(0x100d_1e87, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_1e8a, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x100d_1e8d, 2); if(jnz(0x100d_1e95, 6)) goto l_0x100d_1e95; /* jnz 0x100d1e95 */
            ii(0x100d_1e8f, 4); mov(memb[ss, ebp - 0x50], 2);           /* mov byte [ebp-0x50], 0x2 */
            ii(0x100d_1e93, 2); jmp(0x100d_1e99, 4); goto l_0x100d_1e99; /* jmp 0x100d1e99 */
        l_0x100d_1e95:
            ii(0x100d_1e95, 4); mov(memb[ss, ebp - 0x50], 0xa2);        /* mov byte [ebp-0x50], 0xa2 */
        l_0x100d_1e99:
            ii(0x100d_1e99, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_1e9b, 3); mov(al, memb[ss, ebp - 0x50]);          /* mov al, [ebp-0x50] */
            ii(0x100d_1e9e, 1); push(eax);                              /* push eax */
            ii(0x100d_1e9f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1ea2, 3); mov(ecx, memd[ds, eax + 0x25]);         /* mov ecx, [eax+0x25] */
            ii(0x100d_1ea5, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100d_1ea8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1eab, 3); mov(eax, memd[ds, eax + 0x6e]);         /* mov eax, [eax+0x6e] */
            ii(0x100d_1eae, 5); call(0x100d_4f58, 0x30a5);              /* call 0x100d4f58 */
            ii(0x100d_1eb3, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_1eb6, 4); movsx(edx, memw[ss, ebp - 0x3c]);       /* movsx edx, word [ebp-0x3c] */
            ii(0x100d_1eba, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1ebd, 3); mov(eax, memd[ds, eax + 0x76]);         /* mov eax, [eax+0x76] */
            ii(0x100d_1ec0, 5); call(0x100d_4ef0, 0x302b);              /* call 0x100d4ef0 */
            ii(0x100d_1ec5, 3); movsx(esi, ax);                         /* movsx esi, ax */
            ii(0x100d_1ec8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1ecb, 3); mov(eax, memd[ds, eax + 0x2d]);         /* mov eax, [eax+0x2d] */
            ii(0x100d_1ece, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x100d_1ed0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1ed3, 3); mov(eax, memd[ds, eax + 0x76]);         /* mov eax, [eax+0x76] */
            ii(0x100d_1ed6, 5); call(0x100d_4f58, 0x307d);              /* call 0x100d4f58 */
            ii(0x100d_1edb, 1); cwde();                                 /* cwde */
            ii(0x100d_1edc, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x100d_1ede, 3); mov(memd[ss, ebp - 0x34], esi);         /* mov [ebp-0x34], esi */
            ii(0x100d_1ee1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1ee4, 3); mov(esi, memd[ds, eax + 0x25]);         /* mov esi, [eax+0x25] */
            ii(0x100d_1ee7, 3); sar(esi, 0x10);                         /* sar esi, 0x10 */
            ii(0x100d_1eea, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1eed, 3); mov(eax, memd[ds, eax + 0x76]);         /* mov eax, [eax+0x76] */
            ii(0x100d_1ef0, 5); call(0x100d_4ebc, 0x2fc7);              /* call 0x100d4ebc */
            ii(0x100d_1ef5, 1); cwde();                                 /* cwde */
            ii(0x100d_1ef6, 3); imul(eax, esi);                         /* imul eax, esi */
            ii(0x100d_1ef9, 3); mov(esi, memd[ss, ebp - 0x34]);         /* mov esi, [ebp-0x34] */
            ii(0x100d_1efc, 1); dec(esi);                               /* dec esi */
            ii(0x100d_1efd, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x100d_1eff, 5); call(0x1012_b658, 0x5_9754);            /* call 0x1012b658 */
            ii(0x100d_1f04, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1f07, 3); mov(eax, memd[ds, eax + 0x36]);         /* mov eax, [eax+0x36] */
            ii(0x100d_1f0a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_1f0d, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x100d_1f10, 2); if(jnz(0x100d_1f18, 6)) goto l_0x100d_1f18; /* jnz 0x100d1f18 */
            ii(0x100d_1f12, 4); mov(memb[ss, ebp - 0x54], 2);           /* mov byte [ebp-0x54], 0x2 */
            ii(0x100d_1f16, 2); jmp(0x100d_1f1c, 4); goto l_0x100d_1f1c; /* jmp 0x100d1f1c */
        l_0x100d_1f18:
            ii(0x100d_1f18, 4); mov(memb[ss, ebp - 0x54], 0xa2);        /* mov byte [ebp-0x54], 0xa2 */
        l_0x100d_1f1c:
            ii(0x100d_1f1c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_1f1e, 3); mov(al, memb[ss, ebp - 0x54]);          /* mov al, [ebp-0x54] */
            ii(0x100d_1f21, 1); push(eax);                              /* push eax */
            ii(0x100d_1f22, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1f25, 3); mov(ecx, memd[ds, eax + 0x25]);         /* mov ecx, [eax+0x25] */
            ii(0x100d_1f28, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100d_1f2b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1f2e, 3); mov(eax, memd[ds, eax + 0x7a]);         /* mov eax, [eax+0x7a] */
            ii(0x100d_1f31, 5); call(0x100d_4f58, 0x3022);              /* call 0x100d4f58 */
            ii(0x100d_1f36, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_1f39, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x100d_1f3d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1f40, 3); mov(eax, memd[ds, eax + 0x7a]);         /* mov eax, [eax+0x7a] */
            ii(0x100d_1f43, 5); call(0x100d_4ef0, 0x2fa8);              /* call 0x100d4ef0 */
            ii(0x100d_1f48, 3); movsx(esi, ax);                         /* movsx esi, ax */
            ii(0x100d_1f4b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1f4e, 3); mov(eax, memd[ds, eax + 0x2d]);         /* mov eax, [eax+0x2d] */
            ii(0x100d_1f51, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x100d_1f53, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1f56, 3); mov(eax, memd[ds, eax + 0x7a]);         /* mov eax, [eax+0x7a] */
            ii(0x100d_1f59, 5); call(0x100d_4f58, 0x2ffa);              /* call 0x100d4f58 */
            ii(0x100d_1f5e, 1); cwde();                                 /* cwde */
            ii(0x100d_1f5f, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x100d_1f61, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1f64, 3); mov(eax, memd[ds, eax + 0x25]);         /* mov eax, [eax+0x25] */
            ii(0x100d_1f67, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_1f6a, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x100d_1f6d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1f70, 3); mov(eax, memd[ds, eax + 0x7a]);         /* mov eax, [eax+0x7a] */
            ii(0x100d_1f73, 5); call(0x100d_4ebc, 0x2f44);              /* call 0x100d4ebc */
            ii(0x100d_1f78, 1); cwde();                                 /* cwde */
            ii(0x100d_1f79, 4); imul(eax, memd[ss, ebp - 0x34]);        /* imul eax, [ebp-0x34] */
            ii(0x100d_1f7d, 1); dec(esi);                               /* dec esi */
            ii(0x100d_1f7e, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x100d_1f80, 5); call(0x1012_b658, 0x5_96d3);            /* call 0x1012b658 */
        l_0x100d_1f85:
            ii(0x100d_1f85, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100d_1f89, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x100d_1f8c, 2); if(jge(0x100d_1fa9, 0x1b)) goto l_0x100d_1fa9; /* jge 0x100d1fa9 */
            ii(0x100d_1f8e, 5); call(0x100d_51e4, 0x3251);              /* call 0x100d51e4 */
            ii(0x100d_1f93, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_1f95, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_1f97, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_1f99, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1f9c, 3); mov(eax, memd[ds, eax + 0x66]);         /* mov eax, [eax+0x66] */
            ii(0x100d_1f9f, 5); call(0x100c_fa7c, -0x2528);             /* call 0x100cfa7c */
            ii(0x100d_1fa4, 5); jmp(0x100d_20ec, 0x143); goto l_0x100d_20ec; /* jmp 0x100d20ec */
        l_0x100d_1fa9:
            ii(0x100d_1fa9, 5); call(0x100d_51e4, 0x3236);              /* call 0x100d51e4 */
            ii(0x100d_1fae, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_1fb0, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_1fb2, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100d_1fb7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1fba, 3); mov(eax, memd[ds, eax + 0x66]);         /* mov eax, [eax+0x66] */
            ii(0x100d_1fbd, 5); call(0x100c_fa7c, -0x2546);             /* call 0x100cfa7c */
            ii(0x100d_1fc2, 3); lea(ecx, memd[ss, ebp - 0x3c]);         /* lea ecx, [ebp-0x3c] */
            ii(0x100d_1fc5, 5); mov(ebx, 4);                            /* mov ebx, 0x4 */
            ii(0x100d_1fca, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100d_1fce, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1fd1, 3); mov(eax, memd[ds, eax + 0x31]);         /* mov eax, [eax+0x31] */
            ii(0x100d_1fd4, 5); call(0x1015_4f88, 0x8_2faf);            /* call 0x10154f88 */
            ii(0x100d_1fd9, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100d_1fdc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1fdf, 3); mov(eax, memd[ds, eax + 0x36]);         /* mov eax, [eax+0x36] */
            ii(0x100d_1fe2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_1fe5, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x100d_1fe8, 2); if(jnz(0x100d_1ff0, 6)) goto l_0x100d_1ff0; /* jnz 0x100d1ff0 */
            ii(0x100d_1fea, 4); mov(memb[ss, ebp - 0x58], 2);           /* mov byte [ebp-0x58], 0x2 */
            ii(0x100d_1fee, 2); jmp(0x100d_1ff4, 4); goto l_0x100d_1ff4; /* jmp 0x100d1ff4 */
        l_0x100d_1ff0:
            ii(0x100d_1ff0, 4); mov(memb[ss, ebp - 0x58], 0xa2);        /* mov byte [ebp-0x58], 0xa2 */
        l_0x100d_1ff4:
            ii(0x100d_1ff4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_1ff6, 3); mov(al, memb[ss, ebp - 0x58]);          /* mov al, [ebp-0x58] */
            ii(0x100d_1ff9, 1); push(eax);                              /* push eax */
            ii(0x100d_1ffa, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_1ffd, 3); mov(ecx, memd[ds, eax + 0x25]);         /* mov ecx, [eax+0x25] */
            ii(0x100d_2000, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100d_2003, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2006, 3); mov(eax, memd[ds, eax + 0x6e]);         /* mov eax, [eax+0x6e] */
            ii(0x100d_2009, 5); call(0x100d_4f58, 0x2f4a);              /* call 0x100d4f58 */
            ii(0x100d_200e, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_2011, 4); movsx(edx, memw[ss, ebp - 0x3c]);       /* movsx edx, word [ebp-0x3c] */
            ii(0x100d_2015, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2018, 3); mov(eax, memd[ds, eax + 0x7e]);         /* mov eax, [eax+0x7e] */
            ii(0x100d_201b, 5); call(0x100d_4ef0, 0x2ed0);              /* call 0x100d4ef0 */
            ii(0x100d_2020, 3); movsx(esi, ax);                         /* movsx esi, ax */
            ii(0x100d_2023, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2026, 3); mov(eax, memd[ds, eax + 0x2d]);         /* mov eax, [eax+0x2d] */
            ii(0x100d_2029, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x100d_202b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_202e, 3); mov(eax, memd[ds, eax + 0x7e]);         /* mov eax, [eax+0x7e] */
            ii(0x100d_2031, 5); call(0x100d_4f58, 0x2f22);              /* call 0x100d4f58 */
            ii(0x100d_2036, 1); cwde();                                 /* cwde */
            ii(0x100d_2037, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x100d_2039, 3); mov(memd[ss, ebp - 0x34], esi);         /* mov [ebp-0x34], esi */
            ii(0x100d_203c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_203f, 3); mov(esi, memd[ds, eax + 0x25]);         /* mov esi, [eax+0x25] */
            ii(0x100d_2042, 3); sar(esi, 0x10);                         /* sar esi, 0x10 */
            ii(0x100d_2045, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2048, 3); mov(eax, memd[ds, eax + 0x7e]);         /* mov eax, [eax+0x7e] */
            ii(0x100d_204b, 5); call(0x100d_4ebc, 0x2e6c);              /* call 0x100d4ebc */
            ii(0x100d_2050, 1); cwde();                                 /* cwde */
            ii(0x100d_2051, 3); imul(eax, esi);                         /* imul eax, esi */
            ii(0x100d_2054, 3); mov(esi, memd[ss, ebp - 0x34]);         /* mov esi, [ebp-0x34] */
            ii(0x100d_2057, 1); dec(esi);                               /* dec esi */
            ii(0x100d_2058, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x100d_205a, 5); call(0x1012_b658, 0x5_95f9);            /* call 0x1012b658 */
            ii(0x100d_205f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2062, 3); mov(eax, memd[ds, eax + 0x36]);         /* mov eax, [eax+0x36] */
            ii(0x100d_2065, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_2068, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x100d_206b, 2); if(jnz(0x100d_2073, 6)) goto l_0x100d_2073; /* jnz 0x100d2073 */
            ii(0x100d_206d, 4); mov(memb[ss, ebp - 0x5c], 2);           /* mov byte [ebp-0x5c], 0x2 */
            ii(0x100d_2071, 2); jmp(0x100d_2077, 4); goto l_0x100d_2077; /* jmp 0x100d2077 */
        l_0x100d_2073:
            ii(0x100d_2073, 4); mov(memb[ss, ebp - 0x5c], 0xa2);        /* mov byte [ebp-0x5c], 0xa2 */
        l_0x100d_2077:
            ii(0x100d_2077, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_2079, 3); mov(al, memb[ss, ebp - 0x5c]);          /* mov al, [ebp-0x5c] */
            ii(0x100d_207c, 1); push(eax);                              /* push eax */
            ii(0x100d_207d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2080, 3); mov(ecx, memd[ds, eax + 0x25]);         /* mov ecx, [eax+0x25] */
            ii(0x100d_2083, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100d_2086, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2089, 6); mov(eax, memd[ds, eax + 0x82]);         /* mov eax, [eax+0x82] */
            ii(0x100d_208f, 5); call(0x100d_4f58, 0x2ec4);              /* call 0x100d4f58 */
            ii(0x100d_2094, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_2097, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x100d_209b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_209e, 6); mov(eax, memd[ds, eax + 0x82]);         /* mov eax, [eax+0x82] */
            ii(0x100d_20a4, 5); call(0x100d_4ef0, 0x2e47);              /* call 0x100d4ef0 */
            ii(0x100d_20a9, 3); movsx(esi, ax);                         /* movsx esi, ax */
            ii(0x100d_20ac, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_20af, 3); mov(eax, memd[ds, eax + 0x2d]);         /* mov eax, [eax+0x2d] */
            ii(0x100d_20b2, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x100d_20b4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_20b7, 6); mov(eax, memd[ds, eax + 0x82]);         /* mov eax, [eax+0x82] */
            ii(0x100d_20bd, 5); call(0x100d_4f58, 0x2e96);              /* call 0x100d4f58 */
            ii(0x100d_20c2, 1); cwde();                                 /* cwde */
            ii(0x100d_20c3, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x100d_20c5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_20c8, 3); mov(eax, memd[ds, eax + 0x25]);         /* mov eax, [eax+0x25] */
            ii(0x100d_20cb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_20ce, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x100d_20d1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_20d4, 6); mov(eax, memd[ds, eax + 0x82]);         /* mov eax, [eax+0x82] */
            ii(0x100d_20da, 5); call(0x100d_4ebc, 0x2ddd);              /* call 0x100d4ebc */
            ii(0x100d_20df, 1); cwde();                                 /* cwde */
            ii(0x100d_20e0, 4); imul(eax, memd[ss, ebp - 0x34]);        /* imul eax, [ebp-0x34] */
            ii(0x100d_20e4, 1); dec(esi);                               /* dec esi */
            ii(0x100d_20e5, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x100d_20e7, 5); call(0x1012_b658, 0x5_956c);            /* call 0x1012b658 */
        l_0x100d_20ec:
            ii(0x100d_20ec, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_20ef, 3); mov(eax, memd[ds, eax + 0x29]);         /* mov eax, [eax+0x29] */
            ii(0x100d_20f2, 5); call(Definitions.sys_display_draw_0, 0x9_538d); /* call 0x10167484 */
        l_0x100d_20f7:
            ii(0x100d_20f7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_20f9, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_20fa, 1); pop(edi);                               /* pop edi */
            ii(0x100d_20fb, 1); pop(esi);                               /* pop esi */
            ii(0x100d_20fc, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_20fd, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_20fe, 1); ret();                                  /* ret */
        }
    }
}
