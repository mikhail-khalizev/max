using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_fccd-7575c53d")]
        public void Method_1010_fccd()
        {
            ii(0x1010_fccd, 5); push(0x25c);                            /* push 0x25c */
            ii(0x1010_fcd2, 5); call(Definitions.sys_check_available_stack_size, 0x5_607b); /* call 0x10165d52 */
            ii(0x1010_fcd7, 1); push(ebx);                              /* push ebx */
            ii(0x1010_fcd8, 1); push(ecx);                              /* push ecx */
            ii(0x1010_fcd9, 1); push(edx);                              /* push edx */
            ii(0x1010_fcda, 1); push(esi);                              /* push esi */
            ii(0x1010_fcdb, 1); push(edi);                              /* push edi */
            ii(0x1010_fcdc, 1); push(ebp);                              /* push ebp */
            ii(0x1010_fcdd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_fcdf, 6); sub(esp, 0x240);                        /* sub esp, 0x240 */
            ii(0x1010_fce5, 3); mov(memb[ss, ebp - 0x4], al);           /* mov [ebp-0x4], al */
            ii(0x1010_fce8, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1010_fcec, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x1010_fcef, 6); mov(memb[ss, ebp - 0x220], al);         /* mov [ebp-0x220], al */
            ii(0x1010_fcf5, 6); lea(eax, ebp - 0x234);                  /* lea eax, [ebp-0x234] */
            ii(0x1010_fcfb, 5); call(0x1010_ef7f, -0xd81);              /* call 0x1010ef7f */
        l_0x1010_fd00:
            ii(0x1010_fd00, 5); call(/* sys */ 0x1016_b208, 0x5_b503);  /* call 0x1016b208 */
            ii(0x1010_fd05, 6); mov(memd[ss, ebp - 0x228], eax);        /* mov [ebp-0x228], eax */
            ii(0x1010_fd0b, 7); cmp(memd[ss, ebp - 0x21f], 0);          /* cmp dword [ebp-0x21f], 0x0 */
            ii(0x1010_fd12, 6); if(jz(0x1010_fdd7, 0xbf)) goto l_0x1010_fdd7; /* jz 0x1010fdd7 */
            ii(0x1010_fd18, 6); mov(edx, memd[ss, ebp - 0x228]);        /* mov edx, [ebp-0x228] */
            ii(0x1010_fd1e, 6); mov(eax, memd[ss, ebp - 0x21f]);        /* mov eax, [ebp-0x21f] */
            ii(0x1010_fd24, 5); call(0x100e_b283, -0x2_4aa6);           /* call 0x100eb283 */
            ii(0x1010_fd29, 2); test(al, al);                           /* test al, al */
            ii(0x1010_fd2b, 2); if(jz(0x1010_fd7a, 0x4d)) goto l_0x1010_fd7a; /* jz 0x1010fd7a */
            ii(0x1010_fd2d, 7); cmp(memd[ss, ebp - 0x228], 0x1b);       /* cmp dword [ebp-0x228], 0x1b */
            ii(0x1010_fd34, 2); if(jz(0x1010_fd3f, 0x9)) goto l_0x1010_fd3f; /* jz 0x1010fd3f */
            ii(0x1010_fd36, 7); cmp(memd[ss, ebp - 0x228], 0xd);        /* cmp dword [ebp-0x228], 0xd */
            ii(0x1010_fd3d, 2); if(jnz(0x1010_fd6b, 0x2c)) goto l_0x1010_fd6b; /* jnz 0x1010fd6b */
        l_0x1010_fd3f:
            ii(0x1010_fd3f, 7); cmp(memd[ss, ebp - 0x228], 0xd);        /* cmp dword [ebp-0x228], 0xd */
            ii(0x1010_fd46, 2); if(jnz(0x1010_fd51, 0x9)) goto l_0x1010_fd51; /* jnz 0x1010fd51 */
            ii(0x1010_fd48, 7); mov(memb[ss, ebp - 0x238], 0x1);        /* mov byte [ebp-0x238], 0x1 */
            ii(0x1010_fd4f, 2); jmp(0x1010_fd58, 0x7); goto l_0x1010_fd58; /* jmp 0x1010fd58 */
        l_0x1010_fd51:
            ii(0x1010_fd51, 7); mov(memb[ss, ebp - 0x238], 0);          /* mov byte [ebp-0x238], 0x0 */
        l_0x1010_fd58:
            ii(0x1010_fd58, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_fd5a, 6); mov(dl, memb[ss, ebp - 0x238]);         /* mov dl, [ebp-0x238] */
            ii(0x1010_fd60, 6); lea(eax, ebp - 0x234);                  /* lea eax, [ebp-0x234] */
            ii(0x1010_fd66, 5); call(0x1010_facf, -0x29c);              /* call 0x1010facf */
        l_0x1010_fd6b:
            ii(0x1010_fd6b, 10); mov(memd[ss, ebp - 0x228], 0);         /* mov dword [ebp-0x228], 0x0 */
            ii(0x1010_fd75, 5); jmp(0x1010_fefe, 0x184); goto l_0x1010_fefe; /* jmp 0x1010fefe */
        l_0x1010_fd7a:
            ii(0x1010_fd7a, 10); cmp(memd[ss, ebp - 0x228], 0x7d0);     /* cmp dword [ebp-0x228], 0x7d0 */
            ii(0x1010_fd84, 2); if(jl(0x1010_fd92, 0xc)) goto l_0x1010_fd92; /* jl 0x1010fd92 */
            ii(0x1010_fd86, 10); cmp(memd[ss, ebp - 0x228], 0x7000);    /* cmp dword [ebp-0x228], 0x7000 */
            ii(0x1010_fd90, 2); if(jl(0x1010_fd94, 0x2)) goto l_0x1010_fd94; /* jl 0x1010fd94 */
        l_0x1010_fd92:
            ii(0x1010_fd92, 2); jmp(0x1010_fdae, 0x1a); goto l_0x1010_fdae; /* jmp 0x1010fdae */
        l_0x1010_fd94:
            ii(0x1010_fd94, 6); lea(eax, ebp - 0x234);                  /* lea eax, [ebp-0x234] */
            ii(0x1010_fd9a, 5); call(0x1010_f634, -0x76b);              /* call 0x1010f634 */
            ii(0x1010_fd9f, 10); mov(memd[ss, ebp - 0x228], 0);         /* mov dword [ebp-0x228], 0x0 */
            ii(0x1010_fda9, 5); jmp(0x1010_fefe, 0x150); goto l_0x1010_fefe; /* jmp 0x1010fefe */
        l_0x1010_fdae:
            ii(0x1010_fdae, 7); cmp(memd[ss, ebp - 0x228], 0);          /* cmp dword [ebp-0x228], 0x0 */
            ii(0x1010_fdb5, 2); if(jle(0x1010_fdd7, 0x20)) goto l_0x1010_fdd7; /* jle 0x1010fdd7 */
            ii(0x1010_fdb7, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1010_fdbc, 6); mov(eax, memd[ss, ebp - 0x21f]);        /* mov eax, [ebp-0x21f] */
            ii(0x1010_fdc2, 5); call(0x100e_b283, -0x2_4b44);           /* call 0x100eb283 */
            ii(0x1010_fdc7, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1010_fdcc, 6); lea(eax, ebp - 0x234);                  /* lea eax, [ebp-0x234] */
            ii(0x1010_fdd2, 5); call(0x1010_facf, -0x308);              /* call 0x1010facf */
        l_0x1010_fdd7:
            ii(0x1010_fdd7, 7); cmp(memd[ss, ebp - 0x228], 0);          /* cmp dword [ebp-0x228], 0x0 */
            ii(0x1010_fdde, 2); if(jle(0x1010_fdec, 0xc)) goto l_0x1010_fdec; /* jle 0x1010fdec */
            ii(0x1010_fde0, 10); cmp(memd[ss, ebp - 0x228], 0x7000);    /* cmp dword [ebp-0x228], 0x7000 */
            ii(0x1010_fdea, 2); if(jl(0x1010_fdee, 0x2)) goto l_0x1010_fdee; /* jl 0x1010fdee */
        l_0x1010_fdec:
            ii(0x1010_fdec, 2); jmp(0x1010_fdf2, 0x4); goto l_0x1010_fdf2; /* jmp 0x1010fdf2 */
        l_0x1010_fdee:
            ii(0x1010_fdee, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
        l_0x1010_fdf2:
            ii(0x1010_fdf2, 10); mov(memd[ss, ebp - 0x23c], 0);         /* mov dword [ebp-0x23c], 0x0 */
            ii(0x1010_fdfc, 2); jmp(0x1010_fe0a, 0xc); goto l_0x1010_fe0a; /* jmp 0x1010fe0a */
        l_0x1010_fdfe:
            ii(0x1010_fdfe, 6); mov(eax, memd[ss, ebp - 0x23c]);        /* mov eax, [ebp-0x23c] */
            ii(0x1010_fe04, 6); inc(memd[ss, ebp - 0x23c]);             /* inc dword [ebp-0x23c] */
        l_0x1010_fe0a:
            ii(0x1010_fe0a, 7); movsx(eax, memw[ss, ebp - 0x23c]);      /* movsx eax, word [ebp-0x23c] */
            ii(0x1010_fe11, 3); cmp(eax, 0xd);                          /* cmp eax, 0xd */
            ii(0x1010_fe14, 6); if(jge(0x1010_fefe, 0xe4)) goto l_0x1010_fefe; /* jge 0x1010fefe */
            ii(0x1010_fe1a, 7); movsx(eax, memw[ss, ebp - 0x23c]);      /* movsx eax, word [ebp-0x23c] */
            ii(0x1010_fe21, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_fe24, 8); cmp(memd[ds, eax + ebp - 0x21b], 0);    /* cmp dword [eax+ebp-0x21b], 0x0 */
            ii(0x1010_fe2c, 6); if(jz(0x1010_fef9, 0xc7)) goto l_0x1010_fef9; /* jz 0x1010fef9 */
            ii(0x1010_fe32, 7); movsx(eax, memw[ss, ebp - 0x23c]);      /* movsx eax, word [ebp-0x23c] */
            ii(0x1010_fe39, 5); add(eax, 0x7000);                       /* add eax, 0x7000 */
            ii(0x1010_fe3e, 6); cmp(eax, memd[ss, ebp - 0x228]);        /* cmp eax, [ebp-0x228] */
            ii(0x1010_fe44, 2); if(jnz(0x1010_fe6b, 0x25)) goto l_0x1010_fe6b; /* jnz 0x1010fe6b */
            ii(0x1010_fe46, 4); cmp(memb[ss, ebp - 0x8], 0);            /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1010_fe4a, 2); if(jnz(0x1010_fe62, 0x16)) goto l_0x1010_fe62; /* jnz 0x1010fe62 */
            ii(0x1010_fe4c, 7); movsx(eax, memw[ss, ebp - 0x23c]);      /* movsx eax, word [ebp-0x23c] */
            ii(0x1010_fe53, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_fe56, 7); mov(eax, memd[ds, eax + ebp - 0x21b]);  /* mov eax, [eax+ebp-0x21b] */
            ii(0x1010_fe5d, 5); call(0x100c_fbbe, -0x4_02a4);           /* call 0x100cfbbe */
        l_0x1010_fe62:
            ii(0x1010_fe62, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1010_fe66, 5); jmp(0x1010_fefe, 0x93); goto l_0x1010_fefe; /* jmp 0x1010fefe */
        l_0x1010_fe6b:
            ii(0x1010_fe6b, 7); movsx(edx, memw[ss, ebp - 0x23c]);      /* movsx edx, word [ebp-0x23c] */
            ii(0x1010_fe72, 3); imul(edx, edx, 0xc);                    /* imul edx, edx, 0xc */
            ii(0x1010_fe75, 6); mov(eax, memd[ss, ebp - 0x228]);        /* mov eax, [ebp-0x228] */
            ii(0x1010_fe7b, 7); cmp(eax, memd[ds, edx + ebp - 0x1e3]);  /* cmp eax, [edx+ebp-0x1e3] */
            ii(0x1010_fe82, 2); if(jnz(0x1010_fe9b, 0x17)) goto l_0x1010_fe9b; /* jnz 0x1010fe9b */
            ii(0x1010_fe84, 7); movsx(eax, memw[ss, ebp - 0x23c]);      /* movsx eax, word [ebp-0x23c] */
            ii(0x1010_fe8b, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1010_fe8e, 7); mov(eax, memd[ds, eax + ebp - 0x1e7]);  /* mov eax, [eax+ebp-0x1e7] */
            ii(0x1010_fe95, 6); mov(memd[ss, ebp - 0x228], eax);        /* mov [ebp-0x228], eax */
        l_0x1010_fe9b:
            ii(0x1010_fe9b, 7); movsx(edx, memw[ss, ebp - 0x23c]);      /* movsx edx, word [ebp-0x23c] */
            ii(0x1010_fea2, 3); imul(edx, edx, 0xc);                    /* imul edx, edx, 0xc */
            ii(0x1010_fea5, 6); mov(eax, memd[ss, ebp - 0x228]);        /* mov eax, [ebp-0x228] */
            ii(0x1010_feab, 7); cmp(eax, memd[ds, edx + ebp - 0x1e7]);  /* cmp eax, [edx+ebp-0x1e7] */
            ii(0x1010_feb2, 2); if(jnz(0x1010_fef9, 0x45)) goto l_0x1010_fef9; /* jnz 0x1010fef9 */
            ii(0x1010_feb4, 7); movsx(eax, memw[ss, ebp - 0x23c]);      /* movsx eax, word [ebp-0x23c] */
            ii(0x1010_febb, 3); cmp(eax, 0x6);                          /* cmp eax, 0x6 */
            ii(0x1010_febe, 2); if(jg(0x1010_fed6, 0x16)) goto l_0x1010_fed6; /* jg 0x1010fed6 */
            ii(0x1010_fec0, 7); movsx(eax, memw[ss, ebp - 0x23c]);      /* movsx eax, word [ebp-0x23c] */
            ii(0x1010_fec7, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_feca, 7); mov(eax, memd[ds, eax + ebp - 0x21b]);  /* mov eax, [eax+ebp-0x21b] */
            ii(0x1010_fed1, 5); call(0x100c_fbbe, -0x4_0318);           /* call 0x100cfbbe */
        l_0x1010_fed6:
            ii(0x1010_fed6, 10); add(memd[ss, ebp - 0x228], 0xffff_fc18); /* add dword [ebp-0x228], 0xfffffc18 */
            ii(0x1010_fee0, 7); movsx(edx, memw[ss, ebp - 0x23c]);      /* movsx edx, word [ebp-0x23c] */
            ii(0x1010_fee7, 3); imul(edx, edx, 0xc);                    /* imul edx, edx, 0xc */
            ii(0x1010_feea, 6); lea(eax, ebp - 0x234);                  /* lea eax, [ebp-0x234] */
            ii(0x1010_fef0, 7); call_abs(memd[ds, edx + ebp - 0x1df]);  /* call dword [edx+ebp-0x1df] */
            ii(0x1010_fef7, 2); jmp(0x1010_fefe, 0x5); goto l_0x1010_fefe; /* jmp 0x1010fefe */
        l_0x1010_fef9:
            ii(0x1010_fef9, 5); jmp(0x1010_fdfe, -0x100); goto l_0x1010_fdfe; /* jmp 0x1010fdfe */
        l_0x1010_fefe:
            ii(0x1010_fefe, 7); cmp(memd[ss, ebp - 0x230], 0);          /* cmp dword [ebp-0x230], 0x0 */
            ii(0x1010_ff05, 2); if(jnz(0x1010_ff10, 0x9)) goto l_0x1010_ff10; /* jnz 0x1010ff10 */
            ii(0x1010_ff07, 7); cmp(memd[ss, ebp - 0x22c], 0);          /* cmp dword [ebp-0x22c], 0x0 */
            ii(0x1010_ff0e, 2); if(jz(0x1010_ff12, 0x2)) goto l_0x1010_ff12; /* jz 0x1010ff12 */
        l_0x1010_ff10:
            ii(0x1010_ff10, 2); jmp(0x1010_ff17, 0x5); goto l_0x1010_ff17; /* jmp 0x1010ff17 */
        l_0x1010_ff12:
            ii(0x1010_ff12, 5); jmp(0x1010_fd00, -0x217); goto l_0x1010_fd00; /* jmp 0x1010fd00 */
        l_0x1010_ff17:
            ii(0x1010_ff17, 6); mov(eax, memd[ss, ebp - 0x230]);        /* mov eax, [ebp-0x230] */
            ii(0x1010_ff1d, 6); mov(memd[ss, ebp - 0x240], eax);        /* mov [ebp-0x240], eax */
            ii(0x1010_ff23, 6); mov(eax, memd[ss, ebp - 0x240]);        /* mov eax, [ebp-0x240] */
            ii(0x1010_ff29, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_ff2b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_ff2c, 1); pop(edi);                               /* pop edi */
            ii(0x1010_ff2d, 1); pop(esi);                               /* pop esi */
            ii(0x1010_ff2e, 1); pop(edx);                               /* pop edx */
            ii(0x1010_ff2f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_ff30, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_ff31, 1); ret();                                  /* ret */
        }
    }
}
