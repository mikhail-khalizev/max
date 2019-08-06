using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e6af4b5d-eea1-4910-b246-34e51d893ae7")]
        public void Method_1010_ef7f()
        {
            ii(0x1010_ef7f, 5); pushd(0x58);                            /* push 0x58 */
            ii(0x1010_ef84, 5); calld(Definitions.sys_check_available_stack_size, 0x56dc9); /* call 0x10165d52 */
            ii(0x1010_ef89, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_ef8a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_ef8b, 1); pushd(edx);                             /* push edx */
            ii(0x1010_ef8c, 1); pushd(esi);                             /* push esi */
            ii(0x1010_ef8d, 1); pushd(edi);                             /* push edi */
            ii(0x1010_ef8e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_ef8f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_ef91, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x1010_ef97, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_ef9a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_ef9c, 5); calld(0x100e_883d, -0x26764);           /* call 0x100e883d */
            ii(0x1010_efa1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_efa3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_efa6, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1010_efa8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_efab, 7); mov(memd_a32[ds, eax + 0x4], 0);        /* mov dword [eax+0x4], 0x0 */
            ii(0x1010_efb2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_efb5, 7); mov(memd_a32[ds, eax + 0x8], 0);        /* mov dword [eax+0x8], 0x0 */
            ii(0x1010_efbc, 10); mov(memd_a32[ds, 0x101c_4df0], 0);     /* mov dword [0x101c4df0], 0x0 */
            ii(0x1010_efc6, 5); calld(/* sys */ 0x1016_be34, 0x5ce69);  /* call 0x1016be34 */
            ii(0x1010_efcb, 5); calld(0x100d_533c, -0x39c94);           /* call 0x100d533c */
            ii(0x1010_efd0, 1); cwde();                                 /* cwde */
            ii(0x1010_efd1, 1); pushd(eax);                             /* push eax */
            ii(0x1010_efd2, 5); calld(0x100d_5360, -0x39c77);           /* call 0x100d5360 */
            ii(0x1010_efd7, 1); cwde();                                 /* cwde */
            ii(0x1010_efd8, 1); pushd(eax);                             /* push eax */
            ii(0x1010_efd9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_efdb, 1); pushd(eax);                             /* push eax */
            ii(0x1010_efdc, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_efde, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_efe1, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_efe3, 3); mov(ebx, memd_a32[ds, eax + 0xe]);      /* mov ebx, [eax+0xe] */
            ii(0x1010_efe6, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1010_efe9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_efec, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1010_efee, 5); mov(eax, 0x6c0);                        /* mov eax, 0x6c0 */
            ii(0x1010_eff3, 5); calld(0x100e_8c51, -0x263a7);           /* call 0x100e8c51 */
            ii(0x1010_eff8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_effb, 3); mov(al, memb_a32[ds, eax + 0x14]);      /* mov al, [eax+0x14] */
            ii(0x1010_effe, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_f003, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1010_f006, 2); if(jnzd(0x1010_f011, 0x9)) goto l_0x1010_f011; /* jnz 0x1010f011 */
            ii(0x1010_f008, 7); mov(memd_a32[ss, ebp - 0x10], StringDefinitions.SerialConnectMenu); /* mov dword [ebp-0x10], 0x101a461e */
            ii(0x1010_f00f, 2); jmpd(0x1010_f018, 0x7); goto l_0x1010_f018; /* jmp 0x1010f018 */
        l_0x1010_f011:
            ii(0x1010_f011, 7); mov(memd_a32[ss, ebp - 0x10], StringDefinitions.ModemPlayMenu); /* mov dword [ebp-0x10], 0x101a4632 */
        l_0x1010_f018:
            ii(0x1010_f018, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1010_f01b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f01e, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_f020, 5); calld(0x1010_c628, -0x29fd);            /* call 0x1010c628 */
            ii(0x1010_f025, 7); mov(memd_a32[ss, ebp - 0xc], 0xd);      /* mov dword [ebp-0xc], 0xd */
        l_0x1010_f02c:
            ii(0x1010_f02c, 3); dec(memd_a32[ss, ebp - 0xc]);           /* dec dword [ebp-0xc] */
            ii(0x1010_f02f, 5); cmp(memw_a32[ss, ebp - 0xc], -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x1010_f034, 2); if(jzd(0x1010_f06d, 0x37)) goto l_0x1010_f06d; /* jz 0x1010f06d */
            ii(0x1010_f036, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_f03a, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_f03d, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1010_f040, 7); mov(memd_a32[ds, eax + 0x19], 0);       /* mov dword [eax+0x19], 0x0 */
            ii(0x1010_f047, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_f04b, 3); cmp(eax, 0x6);                          /* cmp eax, 0x6 */
            ii(0x1010_f04e, 2); if(jgd(0x1010_f056, 0x6)) goto l_0x1010_f056; /* jg 0x1010f056 */
            ii(0x1010_f050, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x1010_f054, 2); jmpd(0x1010_f05a, 0x4); goto l_0x1010_f05a; /* jmp 0x1010f05a */
        l_0x1010_f056:
            ii(0x1010_f056, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
        l_0x1010_f05a:
            ii(0x1010_f05a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_f05c, 3); mov(bl, memb_a32[ss, ebp - 0x14]);      /* mov bl, [ebp-0x14] */
            ii(0x1010_f05f, 4); movsx(edx, memb_a32[ss, ebp - 0xc]);    /* movsx edx, byte [ebp-0xc] */
            ii(0x1010_f063, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f066, 5); calld(0x1010_eac5, -0x5a6);             /* call 0x1010eac5 */
            ii(0x1010_f06b, 2); jmpd(0x1010_f02c, -0x41); goto l_0x1010_f02c; /* jmp 0x1010f02c */
        l_0x1010_f06d:
            ii(0x1010_f06d, 7); mov(memd_a32[ss, ebp - 0x8], 0x3);      /* mov dword [ebp-0x8], 0x3 */
            ii(0x1010_f074, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f077, 3); mov(al, memb_a32[ds, eax + 0x14]);      /* mov al, [eax+0x14] */
            ii(0x1010_f07a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_f07f, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1010_f082, 2); if(jnzd(0x1010_f08b, 0x7)) goto l_0x1010_f08b; /* jnz 0x1010f08b */
            ii(0x1010_f084, 7); mov(memd_a32[ss, ebp - 0x8], 0x7);      /* mov dword [ebp-0x8], 0x7 */
        l_0x1010_f08b:
            ii(0x1010_f08b, 6); mov(memw_a32[ss, ebp - 0xc], 0);        /* mov word [ebp-0xc], 0x0 */
            ii(0x1010_f091, 2); jmpd(0x1010_f09a, 0x7); goto l_0x1010_f09a; /* jmp 0x1010f09a */
        l_0x1010_f093:
            ii(0x1010_f093, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_f096, 4); inc(memw_a32[ss, ebp - 0xc]);           /* inc word [ebp-0xc] */
        l_0x1010_f09a:
            ii(0x1010_f09a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_f09d, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1010_f0a1, 2); if(jged(0x1010_f0c4, 0x21)) goto l_0x1010_f0c4; /* jge 0x1010f0c4 */
            ii(0x1010_f0a3, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_f0a7, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_f0aa, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1010_f0ad, 3); mov(eax, memd_a32[ds, eax + 0x19]);     /* mov eax, [eax+0x19] */
            ii(0x1010_f0b0, 5); calld(0x100d_5104, -0x39fb1);           /* call 0x100d5104 */
            ii(0x1010_f0b5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_f0b7, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_f0bb, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_f0be, 4); mov(memd_a32[ds, eax + ebp - 0x30], edx); /* mov [eax+ebp-0x30], edx */
            ii(0x1010_f0c2, 2); jmpd(0x1010_f093, -0x31); goto l_0x1010_f093; /* jmp 0x1010f093 */
        l_0x1010_f0c4:
            ii(0x1010_f0c4, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x1010_f0c7, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_f0cb, 5); calld(/* sys */ 0x1016_9a78, 0x5a9a8);  /* call 0x10169a78 */
            ii(0x1010_f0d0, 6); mov(memw_a32[ss, ebp - 0xc], 0xa);      /* mov word [ebp-0xc], 0xa */
        l_0x1010_f0d6:
            ii(0x1010_f0d6, 4); dec(memw_a32[ss, ebp - 0xc]);           /* dec word [ebp-0xc] */
            ii(0x1010_f0da, 5); cmp(memw_a32[ss, ebp - 0xc], -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x1010_f0df, 2); if(jzd(0x1010_f0f7, 0x16)) goto l_0x1010_f0f7; /* jz 0x1010f0f7 */
            ii(0x1010_f0e1, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_f0e5, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_f0e8, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1010_f0eb, 10); mov(memd_a32[ds, eax + 0x1d9], 0);     /* mov dword [eax+0x1d9], 0x0 */
            ii(0x1010_f0f5, 2); jmpd(0x1010_f0d6, -0x21); goto l_0x1010_f0d6; /* jmp 0x1010f0d6 */
        l_0x1010_f0f7:
            ii(0x1010_f0f7, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1010_f0fc, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_f0ff, 6); add(edx, 0x107);                        /* add edx, 0x107 */
            ii(0x1010_f105, 5); mov(eax, 0x5b);                         /* mov eax, 0x5b */
            ii(0x1010_f10a, 5); calld(0x1007_5fdc, -0x99133);           /* call 0x10075fdc */
            ii(0x1010_f10f, 5); calld(/* sys */ 0x1017_93f8, 0x6a2e4);  /* call 0x101793f8 */
            ii(0x1010_f114, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1010_f119, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_f11c, 6); add(edx, 0x143);                        /* add edx, 0x143 */
            ii(0x1010_f122, 5); mov(eax, 0x5c);                         /* mov eax, 0x5c */
            ii(0x1010_f127, 5); calld(0x1007_5fdc, -0x99150);           /* call 0x10075fdc */
            ii(0x1010_f12c, 5); calld(/* sys */ 0x1017_93f8, 0x6a2c7);  /* call 0x101793f8 */
            ii(0x1010_f131, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x1010_f136, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1010_f139, 6); add(ebx, 0x125);                        /* add ebx, 0x125 */
            ii(0x1010_f13f, 5); mov(edx, 0x5a);                         /* mov edx, 0x5a */
            ii(0x1010_f144, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1010_f149, 5); calld(0x1010_6281, -0x8ecd);            /* call 0x10106281 */
            ii(0x1010_f14e, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x1010_f153, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1010_f156, 6); add(ebx, 0x161);                        /* add ebx, 0x161 */
            ii(0x1010_f15c, 5); mov(edx, 0x5d);                         /* mov edx, 0x5d */
            ii(0x1010_f161, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1010_f166, 5); calld(0x1010_6281, -0x8eea);            /* call 0x10106281 */
            ii(0x1010_f16b, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x1010_f170, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1010_f173, 6); add(ebx, 0x17f);                        /* add ebx, 0x17f */
            ii(0x1010_f179, 5); mov(edx, 0x5e);                         /* mov edx, 0x5e */
            ii(0x1010_f17e, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1010_f183, 5); calld(0x1010_6281, -0x8f07);            /* call 0x10106281 */
            ii(0x1010_f188, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x1010_f18d, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1010_f190, 6); add(ebx, 0x19d);                        /* add ebx, 0x19d */
            ii(0x1010_f196, 5); mov(edx, 0x5f);                         /* mov edx, 0x5f */
            ii(0x1010_f19b, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1010_f1a0, 5); calld(0x1010_6281, -0x8f24);            /* call 0x10106281 */
            ii(0x1010_f1a5, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x1010_f1aa, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1010_f1ad, 6); add(ebx, 0x1bb);                        /* add ebx, 0x1bb */
            ii(0x1010_f1b3, 5); mov(edx, 0x61);                         /* mov edx, 0x61 */
            ii(0x1010_f1b8, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1010_f1bd, 5); calld(0x1010_6281, -0x8f41);            /* call 0x10106281 */
            ii(0x1010_f1c2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f1c5, 5); add(eax, 0x107);                        /* add eax, 0x107 */
            ii(0x1010_f1ca, 5); mov(memd_a32[ds, 0x101b_ab5c], eax);    /* mov [0x101bab5c], eax */
            ii(0x1010_f1cf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f1d2, 5); add(eax, 0x125);                        /* add eax, 0x125 */
            ii(0x1010_f1d7, 5); mov(memd_a32[ds, 0x101b_ab48], eax);    /* mov [0x101bab48], eax */
            ii(0x1010_f1dc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f1df, 5); add(eax, 0x143);                        /* add eax, 0x143 */
            ii(0x1010_f1e4, 5); mov(memd_a32[ds, 0x101b_ab70], eax);    /* mov [0x101bab70], eax */
            ii(0x1010_f1e9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f1ec, 5); add(eax, 0x161);                        /* add eax, 0x161 */
            ii(0x1010_f1f1, 5); mov(memd_a32[ds, 0x101b_ab84], eax);    /* mov [0x101bab84], eax */
            ii(0x1010_f1f6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f1f9, 5); add(eax, 0x17f);                        /* add eax, 0x17f */
            ii(0x1010_f1fe, 5); mov(memd_a32[ds, 0x101b_ab98], eax);    /* mov [0x101bab98], eax */
            ii(0x1010_f203, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f206, 5); add(eax, 0x19d);                        /* add eax, 0x19d */
            ii(0x1010_f20b, 5); mov(memd_a32[ds, 0x101b_abac], eax);    /* mov [0x101babac], eax */
            ii(0x1010_f210, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f213, 5); add(eax, 0x1bb);                        /* add eax, 0x1bb */
            ii(0x1010_f218, 5); mov(memd_a32[ds, 0x101b_abc0], eax);    /* mov [0x101babc0], eax */
            ii(0x1010_f21d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f220, 7); mov(memd_a32[ds, eax + 0x15], 0);       /* mov dword [eax+0x15], 0x0 */
            ii(0x1010_f227, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f22a, 5); calld(0x1010_ee3c, -0x3f3);             /* call 0x1010ee3c */
            ii(0x1010_f22f, 5); calld(/* sys */ 0x1016_bcc4, 0x5ca90);  /* call 0x1016bcc4 */
            ii(0x1010_f234, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_f236, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_f237, 1); popd(edi);                              /* pop edi */
            ii(0x1010_f238, 1); popd(esi);                              /* pop esi */
            ii(0x1010_f239, 1); popd(edx);                              /* pop edx */
            ii(0x1010_f23a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_f23b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_f23c, 1); retd(); return;                         /* ret */
        }
    }
}
