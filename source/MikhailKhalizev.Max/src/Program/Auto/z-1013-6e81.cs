using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_6e81-4551b97")]
        public void Method_1013_6e81()
        {
            ii(0x1013_6e81, 5); pushd(0x160);                           /* push 0x160 */
            ii(0x1013_6e86, 5); calld(Definitions.sys_check_available_stack_size, 0x2_eec7); /* call 0x10165d52 */
            ii(0x1013_6e8b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_6e8c, 1); pushd(esi);                             /* push esi */
            ii(0x1013_6e8d, 1); pushd(edi);                             /* push edi */
            ii(0x1013_6e8e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_6e8f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_6e91, 6); sub(esp, 0x14c);                        /* sub esp, 0x14c */
            ii(0x1013_6e97, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_6e9a, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1013_6e9d, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1013_6ea0, 4); or(memb_a32[ss, ebp - 0x10], 0x1);      /* or byte [ebp-0x10], 0x1 */
            ii(0x1013_6ea4, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_6ea7, 5); calld(0x1013_be76, 0x4fca);             /* call 0x1013be76 */
            ii(0x1013_6eac, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1013_6eaf, 4); and(memb_a32[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x1013_6eb3, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x1013_6eba, 5); mov(edx, 0x101c_3d70);                  /* mov edx, 0x101c3d70 */
            ii(0x1013_6ebf, 6); lea(eax, ebp - 0x8c);                   /* lea eax, [ebp-0x8c] */
            ii(0x1013_6ec5, 5); calld(Definitions.sys_strcpy, 0x2_f005); /* call 0x10165ecf */
            ii(0x1013_6eca, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1013_6ecd, 6); lea(eax, ebp - 0x8c);                   /* lea eax, [ebp-0x8c] */
            ii(0x1013_6ed3, 5); calld(Definitions.sys_strcat, 0x2_f059); /* call 0x10165f31 */
            ii(0x1013_6ed8, 6); lea(edx, ebp - 0x8c);                   /* lea edx, [ebp-0x8c] */
            ii(0x1013_6ede, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_6ee1, 5); calld(0x1013_bf65, 0x507f);             /* call 0x1013bf65 */
            ii(0x1013_6ee6, 2); test(al, al);                           /* test al, al */
            ii(0x1013_6ee8, 2); if(jnzd(0x1013_6ef9, 0xf)) goto l_0x1013_6ef9; /* jnz 0x10136ef9 */
            ii(0x1013_6eea, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_6eec, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_6eef, 5); calld(0x1013_bf1c, 0x5028);             /* call 0x1013bf1c */
            ii(0x1013_6ef4, 5); jmpd(0x1013_774d, 0x854); goto l_0x1013_774d; /* jmp 0x1013774d */
        l_0x1013_6ef9:
            ii(0x1013_6ef9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_6efb, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1013_6f00, 1); cwde();                                 /* cwde */
            ii(0x1013_6f01, 5); calld(0x100f_35f2, -0x4_3914);          /* call 0x100f35f2 */
            ii(0x1013_6f06, 10); mov(memd_a32[ss, ebp - 0x90], 0x4);    /* mov dword [ebp-0x90], 0x4 */
        l_0x1013_6f10:
            ii(0x1013_6f10, 6); dec(memd_a32[ss, ebp - 0x90]);          /* dec dword [ebp-0x90] */
            ii(0x1013_6f16, 8); cmp(memw_a32[ss, ebp - 0x90], -0x1 /* 0xff */); /* cmp word [ebp-0x90], 0xffff */
            ii(0x1013_6f1e, 2); if(jzd(0x1013_6f43, 0x23)) goto l_0x1013_6f43; /* jz 0x10136f43 */
            ii(0x1013_6f20, 7); movsx(eax, memw_a32[ss, ebp - 0x90]);   /* movsx eax, word [ebp-0x90] */
            ii(0x1013_6f27, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_6f2d, 7); movsx(edx, memw_a32[ss, ebp - 0x90]);   /* movsx edx, word [ebp-0x90] */
            ii(0x1013_6f34, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1013_6f3a, 7); mov(memb_a32[ds, edx + ebp - 0x94], al); /* mov [edx+ebp-0x94], al */
            ii(0x1013_6f41, 2); jmpd(0x1013_6f10, -0x33); goto l_0x1013_6f10; /* jmp 0x10136f10 */
        l_0x1013_6f43:
            ii(0x1013_6f43, 5); mov(ebx, 0xb0);                         /* mov ebx, 0xb0 */
            ii(0x1013_6f48, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_6f4a, 6); lea(eax, ebp - 0x144);                  /* lea eax, [ebp-0x144] */
            ii(0x1013_6f50, 5); calld(Definitions.sys_memset, 0x2_ee8b); /* call 0x10165de0 */
            ii(0x1013_6f55, 9); mov(memw_a32[ss, ebp - 0x144], 0x46);   /* mov word [ebp-0x144], 0x46 */
            ii(0x1013_6f5e, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x1013_6f63, 5); calld(0x1007_5fdc, -0xc_0f8c);          /* call 0x10075fdc */
            ii(0x1013_6f68, 6); mov(memb_a32[ss, ebp - 0x142], al);     /* mov [ebp-0x142], al */
            ii(0x1013_6f6e, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_6f71, 6); lea(eax, ebp - 0x141);                  /* lea eax, [ebp-0x141] */
            ii(0x1013_6f77, 5); calld(Definitions.sys_strcpy, 0x2_ef53); /* call 0x10165ecf */
            ii(0x1013_6f7c, 5); mov(eax, 0x45);                         /* mov eax, 0x45 */
            ii(0x1013_6f81, 5); calld(0x1007_5fdc, -0xc_0faa);          /* call 0x10075fdc */
            ii(0x1013_6f86, 6); mov(memb_a32[ss, ebp - 0x123], al);     /* mov [ebp-0x123], al */
            ii(0x1013_6f8c, 6); mov(ax, memw_a32[ds, 0x101c_3982]);     /* mov ax, [0x101c3982] */
            ii(0x1013_6f92, 7); mov(memw_a32[ss, ebp - 0x122], ax);     /* mov [ebp-0x122], ax */
            ii(0x1013_6f99, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1013_6f9e, 5); calld(0x1007_5fdc, -0xc_0fc7);          /* call 0x10075fdc */
            ii(0x1013_6fa3, 6); mov(memb_a32[ss, ebp - 0x9a], al);      /* mov [ebp-0x9a], al */
            ii(0x1013_6fa9, 5); mov(eax, 0x46);                         /* mov eax, 0x46 */
            ii(0x1013_6fae, 5); calld(0x1007_5fdc, -0xc_0fd7);          /* call 0x10075fdc */
            ii(0x1013_6fb3, 7); mov(memw_a32[ss, ebp - 0x99], ax);      /* mov [ebp-0x99], ax */
            ii(0x1013_6fba, 5); mov(eax, 0x47);                         /* mov eax, 0x47 */
            ii(0x1013_6fbf, 5); calld(0x1007_5fdc, -0xc_0fe8);          /* call 0x10075fdc */
            ii(0x1013_6fc4, 7); mov(memw_a32[ss, ebp - 0x97], ax);      /* mov [ebp-0x97], ax */
            ii(0x1013_6fcb, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x1013_6fd0, 5); calld(0x1007_5fdc, -0xc_0ff9);          /* call 0x10075fdc */
            ii(0x1013_6fd5, 6); mov(memb_a32[ss, ebp - 0x95], al);      /* mov [ebp-0x95], al */
            ii(0x1013_6fdb, 10); mov(memd_a32[ss, ebp - 0x90], 0x4);    /* mov dword [ebp-0x90], 0x4 */
        l_0x1013_6fe5:
            ii(0x1013_6fe5, 6); dec(memd_a32[ss, ebp - 0x90]);          /* dec dword [ebp-0x90] */
            ii(0x1013_6feb, 8); cmp(memw_a32[ss, ebp - 0x90], -0x1 /* 0xff */); /* cmp word [ebp-0x90], 0xffff */
            ii(0x1013_6ff3, 6); if(jzd(0x1013_712c, 0x133)) goto l_0x1013_712c; /* jz 0x1013712c */
            ii(0x1013_6ff9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_6ffb, 6); mov(al, memb_a32[ss, ebp - 0x142]);     /* mov al, [ebp-0x142] */
            ii(0x1013_7001, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1013_7004, 2); if(jzd(0x1013_7013, 0xd)) goto l_0x1013_7013; /* jz 0x10137013 */
            ii(0x1013_7006, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_7008, 6); mov(al, memb_a32[ss, ebp - 0x142]);     /* mov al, [ebp-0x142] */
            ii(0x1013_700e, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1013_7011, 2); if(jnzd(0x1013_7015, 0x2)) goto l_0x1013_7015; /* jnz 0x10137015 */
        l_0x1013_7013:
            ii(0x1013_7013, 2); jmpd(0x1013_7022, 0xd); goto l_0x1013_7022; /* jmp 0x10137022 */
        l_0x1013_7015:
            ii(0x1013_7015, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_7017, 6); mov(al, memb_a32[ss, ebp - 0x142]);     /* mov al, [ebp-0x142] */
            ii(0x1013_701d, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1013_7020, 2); if(jnzd(0x1013_7060, 0x3e)) goto l_0x1013_7060; /* jnz 0x10137060 */
        l_0x1013_7022:
            ii(0x1013_7022, 7); movsx(eax, memw_a32[ss, ebp - 0x90]);   /* movsx eax, word [ebp-0x90] */
            ii(0x1013_7029, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_702b, 2); if(jzd(0x1013_704a, 0x1d)) goto l_0x1013_704a; /* jz 0x1013704a */
            ii(0x1013_702d, 7); movsx(eax, memw_a32[ss, ebp - 0x90]);   /* movsx eax, word [ebp-0x90] */
            ii(0x1013_7034, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_703a, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1013_7040, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_7045, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1013_7048, 2); if(jzd(0x1013_704c, 0x2)) goto l_0x1013_704c; /* jz 0x1013704c */
        l_0x1013_704a:
            ii(0x1013_704a, 2); jmpd(0x1013_7060, 0x14); goto l_0x1013_7060; /* jmp 0x10137060 */
        l_0x1013_704c:
            ii(0x1013_704c, 7); movsx(eax, memw_a32[ss, ebp - 0x90]);   /* movsx eax, word [ebp-0x90] */
            ii(0x1013_7053, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_7059, 7); mov(memb_a32[ds, eax + 0x101c_a490], 0x2); /* mov byte [eax+0x101ca490], 0x2 */
        l_0x1013_7060:
            ii(0x1013_7060, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_7062, 6); mov(al, memb_a32[ss, ebp - 0x142]);     /* mov al, [ebp-0x142] */
            ii(0x1013_7068, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x1013_706b, 2); if(jnzd(0x1013_709d, 0x30)) goto l_0x1013_709d; /* jnz 0x1013709d */
            ii(0x1013_706d, 7); movsx(eax, memw_a32[ss, ebp - 0x90]);   /* movsx eax, word [ebp-0x90] */
            ii(0x1013_7074, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_707a, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1013_7080, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_7085, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_7087, 2); if(jzd(0x1013_709d, 0x14)) goto l_0x1013_709d; /* jz 0x1013709d */
            ii(0x1013_7089, 7); movsx(eax, memw_a32[ss, ebp - 0x90]);   /* movsx eax, word [ebp-0x90] */
            ii(0x1013_7090, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_7096, 7); mov(memb_a32[ds, eax + 0x101c_a490], 0x2); /* mov byte [eax+0x101ca490], 0x2 */
        l_0x1013_709d:
            ii(0x1013_709d, 7); movsx(eax, memw_a32[ss, ebp - 0x90]);   /* movsx eax, word [ebp-0x90] */
            ii(0x1013_70a4, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_70aa, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1013_70b0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_70b5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_70b7, 2); if(jzd(0x1013_70e5, 0x2c)) goto l_0x1013_70e5; /* jz 0x101370e5 */
            ii(0x1013_70b9, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x1013_70be, 7); movsx(eax, memw_a32[ss, ebp - 0x90]);   /* movsx eax, word [ebp-0x90] */
            ii(0x1013_70c5, 3); imul(eax, eax, 0x1e);                   /* imul eax, eax, 0x1e */
            ii(0x1013_70c8, 6); lea(ebx, ebp - 0x120);                  /* lea ebx, [ebp-0x120] */
            ii(0x1013_70ce, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1013_70d0, 6); mov(al, memb_a32[ss, ebp - 0x90]);      /* mov al, [ebp-0x90] */
            ii(0x1013_70d6, 2); add(al, 0x63);                          /* add al, 0x63 */
            ii(0x1013_70d8, 3); movsx(edx, al);                         /* movsx edx, al */
            ii(0x1013_70db, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1013_70e0, 5); calld(0x1010_6281, -0x3_0e64);          /* call 0x10106281 */
        l_0x1013_70e5:
            ii(0x1013_70e5, 7); movsx(edx, memw_a32[ss, ebp - 0x90]);   /* movsx edx, word [ebp-0x90] */
            ii(0x1013_70ec, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x1013_70f2, 7); movsx(eax, memw_a32[ss, ebp - 0x90]);   /* movsx eax, word [ebp-0x90] */
            ii(0x1013_70f9, 6); mov(dl, memb_a32[ds, edx + 0x101c_a490]); /* mov dl, [edx+0x101ca490] */
            ii(0x1013_70ff, 7); mov(memb_a32[ds, eax + ebp - 0xa8], dl); /* mov [eax+ebp-0xa8], dl */
            ii(0x1013_7106, 7); movsx(edx, memw_a32[ss, ebp - 0x90]);   /* movsx edx, word [ebp-0x90] */
            ii(0x1013_710d, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x1013_7113, 7); movsx(eax, memw_a32[ss, ebp - 0x90]);   /* movsx eax, word [ebp-0x90] */
            ii(0x1013_711a, 6); mov(dl, memb_a32[ds, edx + 0x101c_a4ef]); /* mov dl, [edx+0x101ca4ef] */
            ii(0x1013_7120, 7); mov(memb_a32[ds, eax + ebp - 0xa3], dl); /* mov [eax+ebp-0xa3], dl */
            ii(0x1013_7127, 5); jmpd(0x1013_6fe5, -0x147); goto l_0x1013_6fe5; /* jmp 0x10136fe5 */
        l_0x1013_712c:
            ii(0x1013_712c, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1013_7133, 2); if(jzd(0x1013_7142, 0xd)) goto l_0x1013_7142; /* jz 0x10137142 */
            ii(0x1013_7135, 5); mov(eax, memd_a32[ds, 0x101c_5628]);    /* mov eax, [0x101c5628] */
            ii(0x1013_713a, 6); mov(memd_a32[ss, ebp - 0x9e], eax);     /* mov [ebp-0x9e], eax */
            ii(0x1013_7140, 2); jmpd(0x1013_714f, 0xd); goto l_0x1013_714f; /* jmp 0x1013714f */
        l_0x1013_7142:
            ii(0x1013_7142, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_7144, 5); calld(/* sys */ 0x1017_8f78, 0x4_1e2f); /* call 0x10178f78 */
            ii(0x1013_7149, 6); mov(memd_a32[ss, ebp - 0x9e], eax);     /* mov [ebp-0x9e], eax */
        l_0x1013_714f:
            ii(0x1013_714f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_7152, 5); calld(Definitions.sys_strlen, 0x3_ad70); /* call 0x10171ec7 */
            ii(0x1013_7157, 7); mov(memw_a32[ss, ebp - 0x90], ax);      /* mov [ebp-0x90], ax */
        l_0x1013_715e:
            ii(0x1013_715e, 7); dec(memw_a32[ss, ebp - 0x90]);          /* dec word [ebp-0x90] */
            ii(0x1013_7165, 8); cmp(memw_a32[ss, ebp - 0x90], -0x1 /* 0xff */); /* cmp word [ebp-0x90], 0xffff */
            ii(0x1013_716d, 2); if(jzd(0x1013_7188, 0x19)) goto l_0x1013_7188; /* jz 0x10137188 */
            ii(0x1013_716f, 7); movsx(eax, memw_a32[ss, ebp - 0x90]);   /* movsx eax, word [ebp-0x90] */
            ii(0x1013_7176, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1013_7179, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1013_717b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_7180, 6); add(memd_a32[ss, ebp - 0x9e], eax);     /* add [ebp-0x9e], eax */
            ii(0x1013_7186, 2); jmpd(0x1013_715e, -0x2a); goto l_0x1013_715e; /* jmp 0x1013715e */
        l_0x1013_7188:
            ii(0x1013_7188, 5); mov(ebx, 0xb0);                         /* mov ebx, 0xb0 */
            ii(0x1013_718d, 6); lea(edx, ebp - 0x144);                  /* lea edx, [ebp-0x144] */
            ii(0x1013_7193, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_7196, 5); calld(0x1013_c055, 0x4eba);             /* call 0x1013c055 */
            ii(0x1013_719b, 5); mov(ebx, 0x44);                         /* mov ebx, 0x44 */
            ii(0x1013_71a0, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1013_71a3, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1013_71a8, 5); calld(0x1010_6304, -0x3_0ea9);          /* call 0x10106304 */
            ii(0x1013_71ad, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x1013_71b2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_71b5, 6); mov(ebx, memd_a32[ds, 0x101c_8172]);    /* mov ebx, [0x101c8172] */
            ii(0x1013_71bb, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1013_71be, 3); imul(ebx, eax);                         /* imul ebx, eax */
            ii(0x1013_71c1, 6); mov(edx, memd_a32[ds, 0x101c_9454]);    /* mov edx, [0x101c9454] */
            ii(0x1013_71c7, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_71ca, 5); calld(0x1013_c055, 0x4e86);             /* call 0x1013c055 */
            ii(0x1013_71cf, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x1013_71d5, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_71d8, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x1013_71dd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_71e0, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1013_71e3, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_71e5, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_71e7, 6); mov(edx, memd_a32[ds, 0x101c_811c]);    /* mov edx, [0x101c811c] */
            ii(0x1013_71ed, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_71f0, 5); calld(0x1013_c055, 0x4e60);             /* call 0x1013c055 */
            ii(0x1013_71f5, 9); mov(memw_a32[ss, ebp - 0x90], 0);       /* mov word [ebp-0x90], 0x0 */
            ii(0x1013_71fe, 2); jmpd(0x1013_720d, 0xd); goto l_0x1013_720d; /* jmp 0x1013720d */
        l_0x1013_7200:
            ii(0x1013_7200, 6); mov(eax, memd_a32[ss, ebp - 0x90]);     /* mov eax, [ebp-0x90] */
            ii(0x1013_7206, 7); inc(memw_a32[ss, ebp - 0x90]);          /* inc word [ebp-0x90] */
        l_0x1013_720d:
            ii(0x1013_720d, 7); movsx(eax, memw_a32[ss, ebp - 0x90]);   /* movsx eax, word [ebp-0x90] */
            ii(0x1013_7214, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1013_7217, 6); if(jged(0x1013_7521, 0x304)) goto l_0x1013_7521; /* jge 0x10137521 */
            ii(0x1013_721d, 7); movsx(eax, memw_a32[ss, ebp - 0x90]);   /* movsx eax, word [ebp-0x90] */
            ii(0x1013_7224, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_722a, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x1013_722f, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_7231, 6); mov(memd_a32[ss, ebp - 0x148], edx);    /* mov [ebp-0x148], edx */
            ii(0x1013_7237, 5); mov(ebx, 0x28);                         /* mov ebx, 0x28 */
            ii(0x1013_723c, 6); mov(edx, memd_a32[ss, ebp - 0x148]);    /* mov edx, [ebp-0x148] */
            ii(0x1013_7242, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_7245, 5); calld(0x1013_c055, 0x4e0b);             /* call 0x1013c055 */
            ii(0x1013_724a, 6); mov(eax, memd_a32[ss, ebp - 0x148]);    /* mov eax, [ebp-0x148] */
            ii(0x1013_7250, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_7252, 3); mov(dl, memb_a32[ds, eax + 0x28]);      /* mov dl, [eax+0x28] */
            ii(0x1013_7255, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_7258, 5); calld(0x1013_c0c5, 0x4e68);             /* call 0x1013c0c5 */
            ii(0x1013_725d, 6); mov(eax, memd_a32[ss, ebp - 0x148]);    /* mov eax, [ebp-0x148] */
            ii(0x1013_7263, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_7265, 3); mov(dl, memb_a32[ds, eax + 0x29]);      /* mov dl, [eax+0x29] */
            ii(0x1013_7268, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_726b, 5); calld(0x1013_c0c5, 0x4e55);             /* call 0x1013c0c5 */
            ii(0x1013_7270, 6); mov(eax, memd_a32[ss, ebp - 0x148]);    /* mov eax, [ebp-0x148] */
            ii(0x1013_7276, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_7278, 6); mov(dl, memb_a32[ds, eax + 0x87]);      /* mov dl, [eax+0x87] */
            ii(0x1013_727e, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_7281, 5); calld(0x1013_c0c5, 0x4e3f);             /* call 0x1013c0c5 */
            ii(0x1013_7286, 5); mov(ebx, 0x60);                         /* mov ebx, 0x60 */
            ii(0x1013_728b, 6); mov(edx, memd_a32[ss, ebp - 0x148]);    /* mov edx, [ebp-0x148] */
            ii(0x1013_7291, 6); add(edx, 0x88);                         /* add edx, 0x88 */
            ii(0x1013_7297, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_729a, 5); calld(0x1013_c055, 0x4db6);             /* call 0x1013c055 */
            ii(0x1013_729f, 6); mov(edx, memd_a32[ss, ebp - 0x148]);    /* mov edx, [ebp-0x148] */
            ii(0x1013_72a5, 6); mov(edx, memd_a32[ds, edx + 0xe8]);     /* mov edx, [edx+0xe8] */
            ii(0x1013_72ab, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_72ae, 5); calld(0x1010_6a2c, -0x3_0887);          /* call 0x10106a2c */
            ii(0x1013_72b3, 6); mov(edx, memd_a32[ss, ebp - 0x148]);    /* mov edx, [ebp-0x148] */
            ii(0x1013_72b9, 6); mov(edx, memd_a32[ds, edx + 0xea]);     /* mov edx, [edx+0xea] */
            ii(0x1013_72bf, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_72c2, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_72c5, 5); calld(0x1013_c0fa, 0x4e30);             /* call 0x1013c0fa */
            ii(0x1013_72ca, 5); mov(ebx, 0x5d);                         /* mov ebx, 0x5d */
            ii(0x1013_72cf, 6); mov(edx, memd_a32[ss, ebp - 0x148]);    /* mov edx, [ebp-0x148] */
            ii(0x1013_72d5, 3); add(edx, 0x2a);                         /* add edx, 0x2a */
            ii(0x1013_72d8, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_72db, 5); calld(0x1013_c055, 0x4d75);             /* call 0x1013c055 */
            ii(0x1013_72e0, 5); mov(ebx, 0xc);                          /* mov ebx, 0xc */
            ii(0x1013_72e5, 6); mov(edx, memd_a32[ss, ebp - 0x148]);    /* mov edx, [ebp-0x148] */
            ii(0x1013_72eb, 6); add(edx, 0xee);                         /* add edx, 0xee */
            ii(0x1013_72f1, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_72f4, 5); calld(0x1013_c055, 0x4d5c);             /* call 0x1013c055 */
            ii(0x1013_72f9, 5); mov(ebx, 0x64);                         /* mov ebx, 0x64 */
            ii(0x1013_72fe, 6); mov(edx, memd_a32[ss, ebp - 0x148]);    /* mov edx, [ebp-0x148] */
            ii(0x1013_7304, 6); add(edx, 0x11d);                        /* add edx, 0x11d */
            ii(0x1013_730a, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_730d, 5); calld(0x1013_c055, 0x4d43);             /* call 0x1013c055 */
            ii(0x1013_7312, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_7314, 6); mov(eax, memd_a32[ss, ebp - 0x148]);    /* mov eax, [ebp-0x148] */
            ii(0x1013_731a, 5); add(eax, 0xfe);                         /* add eax, 0xfe */
            ii(0x1013_731f, 5); calld(0x1013_ad71, 0x3a4d);             /* call 0x1013ad71 */
            ii(0x1013_7324, 2); test(al, al);                           /* test al, al */
            ii(0x1013_7326, 2); if(jzd(0x1013_734c, 0x24)) goto l_0x1013_734c; /* jz 0x1013734c */
            ii(0x1013_7328, 6); mov(eax, memd_a32[ss, ebp - 0x148]);    /* mov eax, [ebp-0x148] */
            ii(0x1013_732e, 5); add(eax, 0xfe);                         /* add eax, 0xfe */
            ii(0x1013_7333, 5); calld(0x1007_6600, -0xc_0d38);          /* call 0x10076600 */
            ii(0x1013_7338, 5); calld(0x1007_6154, -0xc_11e9);          /* call 0x10076154 */
            ii(0x1013_733d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_733f, 3); mov(dx, ax);                            /* mov dx, ax */
            ii(0x1013_7342, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_7345, 5); calld(0x1013_c12f, 0x4de5);             /* call 0x1013c12f */
            ii(0x1013_734a, 2); jmpd(0x1013_7359, 0xd); goto l_0x1013_7359; /* jmp 0x10137359 */
        l_0x1013_734c:
            ii(0x1013_734c, 5); mov(edx, 0xffff);                       /* mov edx, 0xffff */
            ii(0x1013_7351, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_7354, 5); calld(0x1013_c12f, 0x4dd6);             /* call 0x1013c12f */
        l_0x1013_7359:
            ii(0x1013_7359, 6); mov(eax, memd_a32[ss, ebp - 0x148]);    /* mov eax, [ebp-0x148] */
            ii(0x1013_735f, 6); mov(edx, memd_a32[ds, eax + 0x100]);    /* mov edx, [eax+0x100] */
            ii(0x1013_7365, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_7368, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_736b, 5); calld(0x1013_c0fa, 0x4d8a);             /* call 0x1013c0fa */
            ii(0x1013_7370, 6); mov(edx, memd_a32[ss, ebp - 0x148]);    /* mov edx, [ebp-0x148] */
            ii(0x1013_7376, 6); mov(edx, memd_a32[ds, edx + 0x102]);    /* mov edx, [edx+0x102] */
            ii(0x1013_737c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_737f, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_7382, 5); calld(0x1013_c0fa, 0x4d73);             /* call 0x1013c0fa */
            ii(0x1013_7387, 6); mov(edx, memd_a32[ss, ebp - 0x148]);    /* mov edx, [ebp-0x148] */
            ii(0x1013_738d, 6); mov(edx, memd_a32[ds, edx + 0x104]);    /* mov edx, [edx+0x104] */
            ii(0x1013_7393, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_7396, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_7399, 5); calld(0x1013_c0fa, 0x4d5c);             /* call 0x1013c0fa */
            ii(0x1013_739e, 6); mov(eax, memd_a32[ss, ebp - 0x148]);    /* mov eax, [ebp-0x148] */
            ii(0x1013_73a4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_73a6, 6); mov(dl, memb_a32[ds, eax + 0x108]);     /* mov dl, [eax+0x108] */
            ii(0x1013_73ac, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_73af, 5); calld(0x100c_b818, -0x6_bb9c);          /* call 0x100cb818 */
            ii(0x1013_73b4, 6); mov(eax, memd_a32[ss, ebp - 0x148]);    /* mov eax, [ebp-0x148] */
            ii(0x1013_73ba, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_73bc, 6); mov(dl, memb_a32[ds, eax + 0x109]);     /* mov dl, [eax+0x109] */
            ii(0x1013_73c2, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_73c5, 5); calld(0x100c_b818, -0x6_bbb2);          /* call 0x100cb818 */
            ii(0x1013_73ca, 6); mov(eax, memd_a32[ss, ebp - 0x148]);    /* mov eax, [ebp-0x148] */
            ii(0x1013_73d0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_73d2, 6); mov(dl, memb_a32[ds, eax + 0x10a]);     /* mov dl, [eax+0x10a] */
            ii(0x1013_73d8, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_73db, 5); calld(0x100c_b818, -0x6_bbc8);          /* call 0x100cb818 */
            ii(0x1013_73e0, 6); mov(eax, memd_a32[ss, ebp - 0x148]);    /* mov eax, [ebp-0x148] */
            ii(0x1013_73e6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_73e8, 6); mov(dl, memb_a32[ds, eax + 0x10b]);     /* mov dl, [eax+0x10b] */
            ii(0x1013_73ee, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_73f1, 5); calld(0x100c_b818, -0x6_bbde);          /* call 0x100cb818 */
            ii(0x1013_73f6, 6); mov(eax, memd_a32[ss, ebp - 0x148]);    /* mov eax, [ebp-0x148] */
            ii(0x1013_73fc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_73fe, 6); mov(dl, memb_a32[ds, eax + 0x10c]);     /* mov dl, [eax+0x10c] */
            ii(0x1013_7404, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_7407, 5); calld(0x100c_b818, -0x6_bbf4);          /* call 0x100cb818 */
            ii(0x1013_740c, 6); mov(eax, memd_a32[ss, ebp - 0x148]);    /* mov eax, [ebp-0x148] */
            ii(0x1013_7412, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_7414, 6); mov(dl, memb_a32[ds, eax + 0x10d]);     /* mov dl, [eax+0x10d] */
            ii(0x1013_741a, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_741d, 5); calld(0x100c_b818, -0x6_bc0a);          /* call 0x100cb818 */
            ii(0x1013_7422, 6); mov(eax, memd_a32[ss, ebp - 0x148]);    /* mov eax, [ebp-0x148] */
            ii(0x1013_7428, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_742a, 6); mov(dl, memb_a32[ds, eax + 0x112]);     /* mov dl, [eax+0x112] */
            ii(0x1013_7430, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_7433, 5); calld(0x100c_b818, -0x6_bc20);          /* call 0x100cb818 */
            ii(0x1013_7438, 6); mov(eax, memd_a32[ss, ebp - 0x148]);    /* mov eax, [ebp-0x148] */
            ii(0x1013_743e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_7440, 6); mov(dl, memb_a32[ds, eax + 0x10e]);     /* mov dl, [eax+0x10e] */
            ii(0x1013_7446, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_7449, 5); calld(0x100c_b818, -0x6_bc36);          /* call 0x100cb818 */
            ii(0x1013_744e, 6); mov(eax, memd_a32[ss, ebp - 0x148]);    /* mov eax, [ebp-0x148] */
            ii(0x1013_7454, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_7456, 6); mov(dl, memb_a32[ds, eax + 0x10f]);     /* mov dl, [eax+0x10f] */
            ii(0x1013_745c, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_745f, 5); calld(0x100c_b818, -0x6_bc4c);          /* call 0x100cb818 */
            ii(0x1013_7464, 6); mov(eax, memd_a32[ss, ebp - 0x148]);    /* mov eax, [ebp-0x148] */
            ii(0x1013_746a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_746c, 6); mov(dl, memb_a32[ds, eax + 0x110]);     /* mov dl, [eax+0x110] */
            ii(0x1013_7472, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_7475, 5); calld(0x100c_b818, -0x6_bc62);          /* call 0x100cb818 */
            ii(0x1013_747a, 6); mov(eax, memd_a32[ss, ebp - 0x148]);    /* mov eax, [ebp-0x148] */
            ii(0x1013_7480, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_7482, 6); mov(dl, memb_a32[ds, eax + 0x111]);     /* mov dl, [eax+0x111] */
            ii(0x1013_7488, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_748b, 5); calld(0x100c_b818, -0x6_bc78);          /* call 0x100cb818 */
            ii(0x1013_7490, 6); mov(eax, memd_a32[ss, ebp - 0x148]);    /* mov eax, [ebp-0x148] */
            ii(0x1013_7496, 6); mov(edx, memd_a32[ds, eax + 0x111]);    /* mov edx, [eax+0x111] */
            ii(0x1013_749c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_749f, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_74a2, 5); calld(0x1013_c0fa, 0x4c53);             /* call 0x1013c0fa */
            ii(0x1013_74a7, 6); mov(eax, memd_a32[ss, ebp - 0x148]);    /* mov eax, [ebp-0x148] */
            ii(0x1013_74ad, 6); mov(edx, memd_a32[ds, eax + 0x113]);    /* mov edx, [eax+0x113] */
            ii(0x1013_74b3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_74b6, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_74b9, 5); calld(0x1013_c0fa, 0x4c3c);             /* call 0x1013c0fa */
            ii(0x1013_74be, 6); mov(eax, memd_a32[ss, ebp - 0x148]);    /* mov eax, [ebp-0x148] */
            ii(0x1013_74c4, 6); mov(edx, memd_a32[ds, eax + 0x115]);    /* mov edx, [eax+0x115] */
            ii(0x1013_74ca, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_74cd, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_74d0, 5); calld(0x1013_c0fa, 0x4c25);             /* call 0x1013c0fa */
            ii(0x1013_74d5, 6); mov(eax, memd_a32[ss, ebp - 0x148]);    /* mov eax, [ebp-0x148] */
            ii(0x1013_74db, 6); mov(edx, memd_a32[ds, eax + 0x117]);    /* mov edx, [eax+0x117] */
            ii(0x1013_74e1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_74e4, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_74e7, 5); calld(0x1013_c0fa, 0x4c0e);             /* call 0x1013c0fa */
            ii(0x1013_74ec, 5); mov(ebx, 0xba);                         /* mov ebx, 0xba */
            ii(0x1013_74f1, 6); mov(edx, memd_a32[ss, ebp - 0x148]);    /* mov edx, [ebp-0x148] */
            ii(0x1013_74f7, 6); add(edx, 0x181);                        /* add edx, 0x181 */
            ii(0x1013_74fd, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_7500, 5); calld(0x1013_c055, 0x4b50);             /* call 0x1013c055 */
            ii(0x1013_7505, 6); mov(eax, memd_a32[ss, ebp - 0x148]);    /* mov eax, [ebp-0x148] */
            ii(0x1013_750b, 6); mov(edx, memd_a32[ds, eax + 0x119]);    /* mov edx, [eax+0x119] */
            ii(0x1013_7511, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_7514, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_7517, 5); calld(0x1013_c0fa, 0x4bde);             /* call 0x1013c0fa */
            ii(0x1013_751c, 5); jmpd(0x1013_7200, -0x321); goto l_0x1013_7200; /* jmp 0x10137200 */
        l_0x1013_7521:
            ii(0x1013_7521, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_7523, 6); mov(dl, memb_a32[ds, 0x101c_37c8]);     /* mov dl, [0x101c37c8] */
            ii(0x1013_7529, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_752c, 5); calld(0x100c_b818, -0x6_bd19);          /* call 0x100cb818 */
            ii(0x1013_7531, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_7533, 6); mov(dl, memb_a32[ds, 0x101c_37da]);     /* mov dl, [0x101c37da] */
            ii(0x1013_7539, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_753c, 5); calld(0x100c_b818, -0x6_bd29);          /* call 0x100cb818 */
            ii(0x1013_7541, 6); mov(edx, memd_a32[ds, 0x101c_37dc]);    /* mov edx, [0x101c37dc] */
            ii(0x1013_7547, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_754a, 5); calld(0x1010_6a2c, -0x3_0b23);          /* call 0x10106a2c */
            ii(0x1013_754f, 8); movsx(ax, memb_a32[ds, 0x101c_391e]);   /* movsx ax, byte [0x101c391e] */
            ii(0x1013_7557, 7); mov(memw_a32[ss, ebp - 0x90], ax);      /* mov [ebp-0x90], ax */
            ii(0x1013_755e, 7); movsx(edx, memw_a32[ss, ebp - 0x90]);   /* movsx edx, word [ebp-0x90] */
            ii(0x1013_7565, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_7568, 5); calld(0x1013_c0fa, 0x4b8d);             /* call 0x1013c0fa */
            ii(0x1013_756d, 6); mov(edx, memd_a32[ds, 0x101c_3960]);    /* mov edx, [0x101c3960] */
            ii(0x1013_7573, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_7576, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_7579, 5); calld(0x1013_c0fa, 0x4b7c);             /* call 0x1013c0fa */
            ii(0x1013_757e, 5); mov(ebx, 0x51);                         /* mov ebx, 0x51 */
            ii(0x1013_7583, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1013_7586, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1013_758b, 5); calld(0x1010_6304, -0x3_128c);          /* call 0x10106304 */
            ii(0x1013_7590, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1013_7593, 5); mov(eax, 0x101c_61b4);                  /* mov eax, 0x101c61b4 */
            ii(0x1013_7598, 5); calld(0x100d_f6e9, -0x5_7eb4);          /* call 0x100df6e9 */
            ii(0x1013_759d, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1013_75a0, 5); mov(eax, 0x101c_64b0);                  /* mov eax, 0x101c64b0 */
            ii(0x1013_75a5, 5); calld(0x100d_f6e9, -0x5_7ec1);          /* call 0x100df6e9 */
            ii(0x1013_75aa, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1013_75ad, 5); mov(eax, 0x101c_67ac);                  /* mov eax, 0x101c67ac */
            ii(0x1013_75b2, 5); calld(0x100d_f6e9, -0x5_7ece);          /* call 0x100df6e9 */
            ii(0x1013_75b7, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1013_75ba, 5); mov(eax, 0x101c_6aa8);                  /* mov eax, 0x101c6aa8 */
            ii(0x1013_75bf, 5); calld(0x100d_f6e9, -0x5_7edb);          /* call 0x100df6e9 */
            ii(0x1013_75c4, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1013_75c7, 5); mov(eax, 0x101c_8178);                  /* mov eax, 0x101c8178 */
            ii(0x1013_75cc, 5); calld(0x1010_2d8f, -0x3_4842);          /* call 0x10102d8f */
            ii(0x1013_75d1, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1013_75d4, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x1013_75d9, 5); calld(0x1010_2d8f, -0x3_484f);          /* call 0x10102d8f */
            ii(0x1013_75de, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1013_75e1, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1013_75e6, 5); calld(0x1010_2d8f, -0x3_485c);          /* call 0x10102d8f */
            ii(0x1013_75eb, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1013_75ee, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x1013_75f3, 5); calld(0x1010_2d8f, -0x3_4869);          /* call 0x10102d8f */
            ii(0x1013_75f8, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1013_75fb, 5); mov(eax, 0x101c_8190);                  /* mov eax, 0x101c8190 */
            ii(0x1013_7600, 5); calld(0x1010_2d8f, -0x3_4876);          /* call 0x10102d8f */
            ii(0x1013_7605, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1013_7608, 5); mov(eax, 0x101c_39c0);                  /* mov eax, 0x101c39c0 */
            ii(0x1013_760d, 5); calld(0x1010_4171, -0x3_34a1);          /* call 0x10104171 */
            ii(0x1013_7612, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1013_7615, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1013_761a, 5); calld(0x1010_3985, -0x3_3c9a);          /* call 0x10103985 */
            ii(0x1013_761f, 10); mov(memd_a32[ss, ebp - 0x14c], 0);     /* mov dword [ebp-0x14c], 0x0 */
            ii(0x1013_7629, 2); jmpd(0x1013_7637, 0xc); goto l_0x1013_7637; /* jmp 0x10137637 */
        l_0x1013_762b:
            ii(0x1013_762b, 6); mov(eax, memd_a32[ss, ebp - 0x14c]);    /* mov eax, [ebp-0x14c] */
            ii(0x1013_7631, 6); inc(memd_a32[ss, ebp - 0x14c]);         /* inc dword [ebp-0x14c] */
        l_0x1013_7637:
            ii(0x1013_7637, 7); movsx(eax, memw_a32[ss, ebp - 0x14c]);  /* movsx eax, word [ebp-0x14c] */
            ii(0x1013_763e, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1013_7641, 6); if(jged(0x1013_76cc, 0x85)) goto l_0x1013_76cc; /* jge 0x101376cc */
            ii(0x1013_7647, 7); movsx(eax, memw_a32[ss, ebp - 0x14c]);  /* movsx eax, word [ebp-0x14c] */
            ii(0x1013_764e, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_7654, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1013_765a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_765f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_7661, 2); if(jzd(0x1013_76c7, 0x64)) goto l_0x1013_76c7; /* jz 0x101376c7 */
            ii(0x1013_7663, 5); mov(eax, 0x3100);                       /* mov eax, 0x3100 */
            ii(0x1013_7668, 7); movsx(ebx, memw_a32[ss, ebp - 0x14c]);  /* movsx ebx, word [ebp-0x14c] */
            ii(0x1013_766f, 6); imul(ebx, ebx, 0x247);                  /* imul ebx, ebx, 0x247 */
            ii(0x1013_7675, 6); mov(edx, memd_a32[ds, ebx + 0x101c_a6a3]); /* mov edx, [ebx+0x101ca6a3] */
            ii(0x1013_767b, 3); lea(ecx, ebp - 0x20);                   /* lea ecx, [ebp-0x20] */
            ii(0x1013_767e, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_7680, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1013_7682, 5); calld(0x1013_c055, 0x49ce);             /* call 0x1013c055 */
            ii(0x1013_7687, 5); mov(ebx, 0x3100);                       /* mov ebx, 0x3100 */
            ii(0x1013_768c, 7); movsx(eax, memw_a32[ss, ebp - 0x14c]);  /* movsx eax, word [ebp-0x14c] */
            ii(0x1013_7693, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_7699, 6); mov(edx, memd_a32[ds, eax + 0x101c_a6a7]); /* mov edx, [eax+0x101ca6a7] */
            ii(0x1013_769f, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_76a2, 5); calld(0x1013_c055, 0x49ae);             /* call 0x1013c055 */
            ii(0x1013_76a7, 5); mov(ebx, 0x3100);                       /* mov ebx, 0x3100 */
            ii(0x1013_76ac, 7); movsx(edx, memw_a32[ss, ebp - 0x14c]);  /* movsx edx, word [ebp-0x14c] */
            ii(0x1013_76b3, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x1013_76b9, 6); mov(edx, memd_a32[ds, edx + 0x101c_a6ab]); /* mov edx, [edx+0x101ca6ab] */
            ii(0x1013_76bf, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_76c2, 5); calld(0x1013_c055, 0x498e);             /* call 0x1013c055 */
        l_0x1013_76c7:
            ii(0x1013_76c7, 5); jmpd(0x1013_762b, -0xa1); goto l_0x1013_762b; /* jmp 0x1013762b */
        l_0x1013_76cc:
            ii(0x1013_76cc, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_76cf, 5); calld(0x1011_7a37, -0x1_fc9d);          /* call 0x10117a37 */
            ii(0x1013_76d4, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_76d7, 5); calld(0x100a_9ca9, -0x8_da33);          /* call 0x100a9ca9 */
            ii(0x1013_76dc, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_76df, 5); calld(0x1013_bfc1, 0x48dd);             /* call 0x1013bfc1 */
            ii(0x1013_76e4, 9); mov(memw_a32[ss, ebp - 0x90], 0x4);     /* mov word [ebp-0x90], 0x4 */
        l_0x1013_76ed:
            ii(0x1013_76ed, 7); dec(memw_a32[ss, ebp - 0x90]);          /* dec word [ebp-0x90] */
            ii(0x1013_76f4, 8); cmp(memw_a32[ss, ebp - 0x90], -0x1 /* 0xff */); /* cmp word [ebp-0x90], 0xffff */
            ii(0x1013_76fc, 2); if(jzd(0x1013_7721, 0x23)) goto l_0x1013_7721; /* jz 0x10137721 */
            ii(0x1013_76fe, 7); movsx(eax, memw_a32[ss, ebp - 0x90]);   /* movsx eax, word [ebp-0x90] */
            ii(0x1013_7705, 7); movsx(edx, memw_a32[ss, ebp - 0x90]);   /* movsx edx, word [ebp-0x90] */
            ii(0x1013_770c, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x1013_7712, 7); mov(al, memb_a32[ds, eax + ebp - 0x94]); /* mov al, [eax+ebp-0x94] */
            ii(0x1013_7719, 6); mov(memb_a32[ds, edx + 0x101c_a490], al); /* mov [edx+0x101ca490], al */
            ii(0x1013_771f, 2); jmpd(0x1013_76ed, -0x34); goto l_0x1013_76ed; /* jmp 0x101376ed */
        l_0x1013_7721:
            ii(0x1013_7721, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1013_7725, 2); if(jzd(0x1013_7743, 0x1c)) goto l_0x1013_7743; /* jz 0x10137743 */
            ii(0x1013_7727, 5); calld(0x100d_5470, -0x6_22bc);          /* call 0x100d5470 */
            ii(0x1013_772c, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1013_772f, 5); mov(ebx, 0x467);                        /* mov ebx, 0x467 */
            ii(0x1013_7734, 5); mov(edx, 0x466);                        /* mov edx, 0x466 */
            ii(0x1013_7739, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1013_773e, 5); calld(0x1013_daea, 0x63a7);             /* call 0x1013daea */
        l_0x1013_7743:
            ii(0x1013_7743, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_7745, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_7748, 5); calld(0x1013_bf1c, 0x47cf);             /* call 0x1013bf1c */
        l_0x1013_774d:
            ii(0x1013_774d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_774f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_7750, 1); popd(edi);                              /* pop edi */
            ii(0x1013_7751, 1); popd(esi);                              /* pop esi */
            ii(0x1013_7752, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_7753, 1); retd(); return;                         /* ret */
        }
    }
}
