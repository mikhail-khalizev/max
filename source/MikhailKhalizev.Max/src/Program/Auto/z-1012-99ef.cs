using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a38e3fbd-4c14-4cce-a6db-65e4e4e261ad")]
        public void Method_1012_99ef()
        {
            ii(0x1012_99ef, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1012_99f4, 5); calld(Definitions.sys_check_available_stack_size, 0x3_c359); /* call 0x10165d52 */
            ii(0x1012_99f9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_99fa, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_99fb, 1); pushd(edx);                             /* push edx */
            ii(0x1012_99fc, 1); pushd(esi);                             /* push esi */
            ii(0x1012_99fd, 1); pushd(edi);                             /* push edi */
            ii(0x1012_99fe, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_99ff, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_9a01, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1012_9a07, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1012_9a0b, 5); calld(0x1012_75ed, -0x2423);            /* call 0x101275ed */
            ii(0x1012_9a10, 7); mov(memd_a32[ss, ebp - 0x10], 0x4);     /* mov dword [ebp-0x10], 0x4 */
        l_0x1012_9a17:
            ii(0x1012_9a17, 3); dec(memd_a32[ss, ebp - 0x10]);          /* dec dword [ebp-0x10] */
            ii(0x1012_9a1a, 5); cmp(memw_a32[ss, ebp - 0x10], -0x1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x1012_9a1f, 2); if(jzd(0x1012_9a59, 0x38)) goto l_0x1012_9a59; /* jz 0x10129a59 */
            ii(0x1012_9a21, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_9a25, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_9a2b, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1012_9a31, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_9a36, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1012_9a39, 2); if(jnzd(0x1012_9a57, 0x1c)) goto l_0x1012_9a57; /* jnz 0x10129a57 */
            ii(0x1012_9a3b, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_9a3f, 3); imul(edx, eax, 0x13);                   /* imul edx, eax, 0x13 */
            ii(0x1012_9a42, 5); mov(eax, 0x101c_35b4);                  /* mov eax, 0x101c35b4 */
            ii(0x1012_9a47, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_9a49, 5); calld(Definitions.my_2_get_count, -0x9_e6e6); /* call 0x1008b368 */
            ii(0x1012_9a4e, 1); cwde();                                 /* cwde */
            ii(0x1012_9a4f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_9a51, 2); if(jnzd(0x1012_9a57, 0x4)) goto l_0x1012_9a57; /* jnz 0x10129a57 */
            ii(0x1012_9a53, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
        l_0x1012_9a57:
            ii(0x1012_9a57, 2); jmpd(0x1012_9a17, -0x42); goto l_0x1012_9a17; /* jmp 0x10129a17 */
        l_0x1012_9a59:
            ii(0x1012_9a59, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1012_9a5d, 2); if(jzd(0x1012_9a68, 0x9)) goto l_0x1012_9a68; /* jz 0x10129a68 */
            ii(0x1012_9a5f, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1012_9a66, 2); if(jnzd(0x1012_9a6d, 0x5)) goto l_0x1012_9a6d; /* jnz 0x10129a6d */
        l_0x1012_9a68:
            ii(0x1012_9a68, 5); jmpd(0x1012_9b9a, 0x12d); goto l_0x1012_9b9a; /* jmp 0x10129b9a */
        l_0x1012_9a6d:
            ii(0x1012_9a6d, 5); calld(0x100c_aa00, -0x5_f072);          /* call 0x100caa00 */
            ii(0x1012_9a72, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_9a77, 1); pushd(eax);                             /* push eax */
            ii(0x1012_9a78, 5); calld(0x100c_aa20, -0x5_f05d);          /* call 0x100caa20 */
            ii(0x1012_9a7d, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1012_9a7f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_9a81, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_9a83, 5); mov(eax, StringDefinitions.WaitingForRemotePlayerToSelectStartingLocation); /* mov eax, 0x101a8394 */
            ii(0x1012_9a88, 5); calld(0x1011_5d23, -0x1_3d6a);          /* call 0x10115d23 */
            ii(0x1012_9a8d, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_9a92, 5); calld(0x1012_0d94, -0x8d03);            /* call 0x10120d94 */
        l_0x1012_9a97:
            ii(0x1012_9a97, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1012_9a9b, 2); if(jzd(0x1012_9aa6, 0x9)) goto l_0x1012_9aa6; /* jz 0x10129aa6 */
            ii(0x1012_9a9d, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1012_9aa4, 2); if(jnzd(0x1012_9aab, 0x5)) goto l_0x1012_9aab; /* jnz 0x10129aab */
        l_0x1012_9aa6:
            ii(0x1012_9aa6, 5); jmpd(0x1012_9b95, 0xea); goto l_0x1012_9b95; /* jmp 0x10129b95 */
        l_0x1012_9aab:
            ii(0x1012_9aab, 5); calld(0x1012_75ed, -0x24c3);            /* call 0x101275ed */
            ii(0x1012_9ab0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_9ab2, 5); calld(0x1010_0efe, -0x2_8bb9);          /* call 0x10100efe */
            ii(0x1012_9ab7, 5); calld(0x100e_a7e7, -0x3_f2d5);          /* call 0x100ea7e7 */
            ii(0x1012_9abc, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1012_9ac0, 7); mov(memd_a32[ss, ebp - 0x10], 0x4);     /* mov dword [ebp-0x10], 0x4 */
        l_0x1012_9ac7:
            ii(0x1012_9ac7, 3); dec(memd_a32[ss, ebp - 0x10]);          /* dec dword [ebp-0x10] */
            ii(0x1012_9aca, 5); cmp(memw_a32[ss, ebp - 0x10], -0x1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x1012_9acf, 2); if(jzd(0x1012_9b09, 0x38)) goto l_0x1012_9b09; /* jz 0x10129b09 */
            ii(0x1012_9ad1, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_9ad5, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_9adb, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1012_9ae1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_9ae6, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1012_9ae9, 2); if(jnzd(0x1012_9b07, 0x1c)) goto l_0x1012_9b07; /* jnz 0x10129b07 */
            ii(0x1012_9aeb, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_9aef, 3); imul(edx, eax, 0x13);                   /* imul edx, eax, 0x13 */
            ii(0x1012_9af2, 5); mov(eax, 0x101c_35b4);                  /* mov eax, 0x101c35b4 */
            ii(0x1012_9af7, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_9af9, 5); calld(Definitions.my_2_get_count, -0x9_e796); /* call 0x1008b368 */
            ii(0x1012_9afe, 1); cwde();                                 /* cwde */
            ii(0x1012_9aff, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_9b01, 2); if(jnzd(0x1012_9b07, 0x4)) goto l_0x1012_9b07; /* jnz 0x10129b07 */
            ii(0x1012_9b03, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
        l_0x1012_9b07:
            ii(0x1012_9b07, 2); jmpd(0x1012_9ac7, -0x42); goto l_0x1012_9ac7; /* jmp 0x10129ac7 */
        l_0x1012_9b09:
            ii(0x1012_9b09, 5); calld(/* sys */ 0x1016_b208, 0x4_16fa); /* call 0x1016b208 */
            ii(0x1012_9b0e, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1012_9b11, 4); cmp(memd_a32[ss, ebp - 0x14], 0x1b);    /* cmp dword [ebp-0x14], 0x1b */
            ii(0x1012_9b15, 2); if(jzd(0x1012_9b20, 0x9)) goto l_0x1012_9b20; /* jz 0x10129b20 */
            ii(0x1012_9b17, 7); cmp(memd_a32[ss, ebp - 0x14], 0x12d);   /* cmp dword [ebp-0x14], 0x12d */
            ii(0x1012_9b1e, 2); if(jnzd(0x1012_9b22, 0x2)) goto l_0x1012_9b22; /* jnz 0x10129b22 */
        l_0x1012_9b20:
            ii(0x1012_9b20, 2); jmpd(0x1012_9b2b, 0x9); goto l_0x1012_9b2b; /* jmp 0x10129b2b */
        l_0x1012_9b22:
            ii(0x1012_9b22, 7); cmp(memd_a32[ss, ebp - 0x14], 0x144);   /* cmp dword [ebp-0x14], 0x144 */
            ii(0x1012_9b29, 2); if(jnzd(0x1012_9b72, 0x47)) goto l_0x1012_9b72; /* jnz 0x10129b72 */
        l_0x1012_9b2b:
            ii(0x1012_9b2b, 4); cmp(memd_a32[ss, ebp - 0x14], 0x1b);    /* cmp dword [ebp-0x14], 0x1b */
            ii(0x1012_9b2f, 2); if(jnzd(0x1012_9b3a, 0x9)) goto l_0x1012_9b3a; /* jnz 0x10129b3a */
            ii(0x1012_9b31, 7); mov(memb_a32[ds, 0x101c_391e], 0xe);    /* mov byte [0x101c391e], 0xe */
            ii(0x1012_9b38, 2); jmpd(0x1012_9b53, 0x19); goto l_0x1012_9b53; /* jmp 0x10129b53 */
        l_0x1012_9b3a:
            ii(0x1012_9b3a, 7); cmp(memd_a32[ss, ebp - 0x14], 0x12d);   /* cmp dword [ebp-0x14], 0x12d */
            ii(0x1012_9b41, 2); if(jnzd(0x1012_9b4c, 0x9)) goto l_0x1012_9b4c; /* jnz 0x10129b4c */
            ii(0x1012_9b43, 7); mov(memb_a32[ds, 0x101c_391e], 0x3);    /* mov byte [0x101c391e], 0x3 */
            ii(0x1012_9b4a, 2); jmpd(0x1012_9b53, 0x7); goto l_0x1012_9b53; /* jmp 0x10129b53 */
        l_0x1012_9b4c:
            ii(0x1012_9b4c, 7); mov(memb_a32[ds, 0x101c_391e], 0xf);    /* mov byte [0x101c391e], 0xf */
        l_0x1012_9b53:
            ii(0x1012_9b53, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_9b55, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_9b57, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1012_9b5c, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_9b5f, 5); mov(eax, 0x2a);                         /* mov eax, 0x2a */
            ii(0x1012_9b64, 5); calld(0x1012_8897, -0x12d2);            /* call 0x10128897 */
            ii(0x1012_9b69, 4); mov(memb_a32[ss, ebp - 0x4], 0x6);      /* mov byte [ebp-0x4], 0x6 */
            ii(0x1012_9b6d, 5); jmpd(0x1012_9cba, 0x148); goto l_0x1012_9cba; /* jmp 0x10129cba */
        l_0x1012_9b72:
            ii(0x1012_9b72, 4); cmp(memd_a32[ss, ebp - 0x14], 0x3f);    /* cmp dword [ebp-0x14], 0x3f */
            ii(0x1012_9b76, 2); if(jnzd(0x1012_9b90, 0x18)) goto l_0x1012_9b90; /* jnz 0x10129b90 */
            ii(0x1012_9b78, 5); calld(0x100d_4e6c, -0x5_4d11);          /* call 0x100d4e6c */
            ii(0x1012_9b7d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_9b7f, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1012_9b81, 5); mov(edx, 0x26);                         /* mov edx, 0x26 */
            ii(0x1012_9b86, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1012_9b8b, 5); calld(0x1010_5b00, -0x2_4090);          /* call 0x10105b00 */
        l_0x1012_9b90:
            ii(0x1012_9b90, 5); jmpd(0x1012_9a97, -0xfe); goto l_0x1012_9a97; /* jmp 0x10129a97 */
        l_0x1012_9b95:
            ii(0x1012_9b95, 5); calld(0x1011_606c, -0x1_3b2e);          /* call 0x1011606c */
        l_0x1012_9b9a:
            ii(0x1012_9b9a, 7); mov(memd_a32[ss, ebp - 0x10], 0x4);     /* mov dword [ebp-0x10], 0x4 */
        l_0x1012_9ba1:
            ii(0x1012_9ba1, 3); dec(memd_a32[ss, ebp - 0x10]);          /* dec dword [ebp-0x10] */
            ii(0x1012_9ba4, 5); cmp(memw_a32[ss, ebp - 0x10], -0x1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x1012_9ba9, 2); if(jzd(0x1012_9bff, 0x54)) goto l_0x1012_9bff; /* jz 0x10129bff */
            ii(0x1012_9bab, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_9baf, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_9bb5, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1012_9bbb, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_9bc0, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1012_9bc3, 2); if(jnzd(0x1012_9bfd, 0x38)) goto l_0x1012_9bfd; /* jnz 0x10129bfd */
            ii(0x1012_9bc5, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1012_9bc9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_9bcb, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1012_9bd0, 1); cwde();                                 /* cwde */
            ii(0x1012_9bd1, 5); calld(0x100f_b9d3, -0x2_e203);          /* call 0x100fb9d3 */
            ii(0x1012_9bd6, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1012_9bd9, 4); cmp(memb_a32[ss, ebp - 0xc], 0);        /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1012_9bdd, 2); if(jzd(0x1012_9bfd, 0x1e)) goto l_0x1012_9bfd; /* jz 0x10129bfd */
            ii(0x1012_9bdf, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_9be3, 3); imul(edx, eax, 0x13);                   /* imul edx, eax, 0x13 */
            ii(0x1012_9be6, 5); mov(eax, 0x101c_35b4);                  /* mov eax, 0x101c35b4 */
            ii(0x1012_9beb, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_9bed, 5); calld(0x1009_caf8, -0x8_d0fa);          /* call 0x1009caf8 */
            ii(0x1012_9bf2, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1012_9bf5, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x1012_9bf8, 5); jmpd(0x1012_9cba, 0xbd); goto l_0x1012_9cba; /* jmp 0x10129cba */
        l_0x1012_9bfd:
            ii(0x1012_9bfd, 2); jmpd(0x1012_9ba1, -0x5e); goto l_0x1012_9ba1; /* jmp 0x10129ba1 */
        l_0x1012_9bff:
            ii(0x1012_9bff, 7); mov(memd_a32[ss, ebp - 0x10], 0x4);     /* mov dword [ebp-0x10], 0x4 */
        l_0x1012_9c06:
            ii(0x1012_9c06, 3); dec(memd_a32[ss, ebp - 0x10]);          /* dec dword [ebp-0x10] */
            ii(0x1012_9c09, 5); cmp(memw_a32[ss, ebp - 0x10], -0x1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x1012_9c0e, 6); if(jzd(0x1012_9cac, 0x98)) goto l_0x1012_9cac; /* jz 0x10129cac */
            ii(0x1012_9c14, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_9c18, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_9c1e, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1012_9c24, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_9c29, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1012_9c2c, 6); if(jnzd(0x1012_9ca7, 0x75)) goto l_0x1012_9ca7; /* jnz 0x10129ca7 */
            ii(0x1012_9c32, 7); mov(memd_a32[ss, ebp - 0x18], 0x4);     /* mov dword [ebp-0x18], 0x4 */
        l_0x1012_9c39:
            ii(0x1012_9c39, 3); dec(memd_a32[ss, ebp - 0x18]);          /* dec dword [ebp-0x18] */
            ii(0x1012_9c3c, 5); cmp(memw_a32[ss, ebp - 0x18], -0x1 /* 0xff */); /* cmp word [ebp-0x18], 0xffff */
            ii(0x1012_9c41, 2); if(jzd(0x1012_9ca7, 0x64)) goto l_0x1012_9ca7; /* jz 0x10129ca7 */
            ii(0x1012_9c43, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_9c46, 4); cmp(ax, memw_a32[ss, ebp - 0x18]);      /* cmp ax, [ebp-0x18] */
            ii(0x1012_9c4a, 2); if(jzd(0x1012_9c66, 0x1a)) goto l_0x1012_9c66; /* jz 0x10129c66 */
            ii(0x1012_9c4c, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1012_9c50, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_9c56, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1012_9c5c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_9c61, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1012_9c64, 2); if(jzd(0x1012_9c68, 0x2)) goto l_0x1012_9c68; /* jz 0x10129c68 */
        l_0x1012_9c66:
            ii(0x1012_9c66, 2); jmpd(0x1012_9ca5, 0x3d); goto l_0x1012_9ca5; /* jmp 0x10129ca5 */
        l_0x1012_9c68:
            ii(0x1012_9c68, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1012_9c6c, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_9c70, 5); calld(0x100f_b9d3, -0x2_e2a2);          /* call 0x100fb9d3 */
            ii(0x1012_9c75, 2); test(al, al);                           /* test al, al */
            ii(0x1012_9c77, 2); if(jzd(0x1012_9ca5, 0x2c)) goto l_0x1012_9ca5; /* jz 0x10129ca5 */
            ii(0x1012_9c79, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_9c7d, 3); imul(edx, eax, 0x13);                   /* imul edx, eax, 0x13 */
            ii(0x1012_9c80, 5); mov(eax, 0x101c_35b4);                  /* mov eax, 0x101c35b4 */
            ii(0x1012_9c85, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_9c87, 5); calld(0x1009_caf8, -0x8_d194);          /* call 0x1009caf8 */
            ii(0x1012_9c8c, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1012_9c90, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1012_9c93, 5); mov(edx, 0x101c_35b4);                  /* mov edx, 0x101c35b4 */
            ii(0x1012_9c98, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_9c9a, 5); calld(0x1009_caf8, -0x8_d1a7);          /* call 0x1009caf8 */
            ii(0x1012_9c9f, 4); mov(memb_a32[ss, ebp - 0x4], 0x5);      /* mov byte [ebp-0x4], 0x5 */
            ii(0x1012_9ca3, 2); jmpd(0x1012_9cba, 0x15); goto l_0x1012_9cba; /* jmp 0x10129cba */
        l_0x1012_9ca5:
            ii(0x1012_9ca5, 2); jmpd(0x1012_9c39, -0x6e); goto l_0x1012_9c39; /* jmp 0x10129c39 */
        l_0x1012_9ca7:
            ii(0x1012_9ca7, 5); jmpd(0x1012_9c06, -0xa6); goto l_0x1012_9c06; /* jmp 0x10129c06 */
        l_0x1012_9cac:
            ii(0x1012_9cac, 5); mov(eax, memd_a32[ds, 0x101c_5628]);    /* mov eax, [0x101c5628] */
            ii(0x1012_9cb1, 5); calld(/* sys */ 0x1016_5ebf, 0x3_c209); /* call 0x10165ebf */
            ii(0x1012_9cb6, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
        l_0x1012_9cba:
            ii(0x1012_9cba, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1012_9cbd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_9cbf, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_9cc0, 1); popd(edi);                              /* pop edi */
            ii(0x1012_9cc1, 1); popd(esi);                              /* pop esi */
            ii(0x1012_9cc2, 1); popd(edx);                              /* pop edx */
            ii(0x1012_9cc3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_9cc4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_9cc5, 1); retd(); return;                         /* ret */
        }
    }
}
