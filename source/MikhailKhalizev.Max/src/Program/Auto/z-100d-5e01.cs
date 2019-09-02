using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_5e01-3f846200")]
        public void Method_100d_5e01()
        {
            ii(0x100d_5e01, 5); push(0x2c);                             /* push 0x2c */
            ii(0x100d_5e06, 5); call(Definitions.sys_check_available_stack_size, 0x8_ff47); /* call 0x10165d52 */
            ii(0x100d_5e0b, 1); push(ebx);                              /* push ebx */
            ii(0x100d_5e0c, 1); push(ecx);                              /* push ecx */
            ii(0x100d_5e0d, 1); push(esi);                              /* push esi */
            ii(0x100d_5e0e, 1); push(edi);                              /* push edi */
            ii(0x100d_5e0f, 1); push(ebp);                              /* push ebp */
            ii(0x100d_5e10, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_5e12, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100d_5e18, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_5e1b, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100d_5e1e, 4); cmp(memd[ss, ebp - 4], 0);              /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100d_5e22, 2); if(jle(0x100d_5e2d, 9)) goto l_0x100d_5e2d; /* jle 0x100d5e2d */
            ii(0x100d_5e24, 7); cmp(memd[ss, ebp - 4], 0x7000);         /* cmp dword [ebp-0x4], 0x7000 */
            ii(0x100d_5e2b, 2); if(jl(0x100d_5e2f, 2)) goto l_0x100d_5e2f; /* jl 0x100d5e2f */
        l_0x100d_5e2d:
            ii(0x100d_5e2d, 2); jmp(0x100d_5e39, 0xa); goto l_0x100d_5e39; /* jmp 0x100d5e39 */
        l_0x100d_5e2f:
            ii(0x100d_5e2f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_5e32, 7); mov(memb[ds, eax + 0x90], 0);           /* mov byte [eax+0x90], 0x0 */
        l_0x100d_5e39:
            ii(0x100d_5e39, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_5e3c, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_5e3f, 5); jmp(0x100d_5f93, 0x14f); goto l_0x100d_5f93; /* jmp 0x100d5f93 */
        l_0x100d_5e44:
            ii(0x100d_5e44, 5); call(0x1011_6ba6, 0x4_0d5d);            /* call 0x10116ba6 */
            ii(0x100d_5e49, 5); jmp(0x100d_5fff, 0x1b1); goto l_0x100d_5fff; /* jmp 0x100d5fff */
        l_0x100d_5e4e:
            ii(0x100d_5e4e, 5); call(0x100d_4e6c, -0xfe7);              /* call 0x100d4e6c */
            ii(0x100d_5e53, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_5e55, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_5e57, 5); mov(edx, 0x26);                         /* mov edx, 0x26 */
            ii(0x100d_5e5c, 5); mov(eax, 0x16);                         /* mov eax, 0x16 */
            ii(0x100d_5e61, 5); call(0x1010_5b00, 0x2_fc9a);            /* call 0x10105b00 */
            ii(0x100d_5e66, 5); jmp(0x100d_5fff, 0x194); goto l_0x100d_5fff; /* jmp 0x100d5fff */
        l_0x100d_5e6b:
            ii(0x100d_5e6b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_5e6e, 3); mov(eax, memd[ds, eax + 0x4e]);         /* mov eax, [eax+0x4e] */
            ii(0x100d_5e71, 5); call(0x100e_b68a, 0x1_5814);            /* call 0x100eb68a */
            ii(0x100d_5e76, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100d_5e7d, 2); jmp(0x100d_5e85, 6); goto l_0x100d_5e85; /* jmp 0x100d5e85 */
        l_0x100d_5e7f:
            ii(0x100d_5e7f, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_5e82, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
        l_0x100d_5e85:
            ii(0x100d_5e85, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100d_5e89, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x100d_5e8c, 2); if(jge(0x100d_5ed9, 0x4b)) goto l_0x100d_5ed9; /* jge 0x100d5ed9 */
            ii(0x100d_5e8e, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100d_5e92, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100d_5e95, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x100d_5e98, 3); mov(eax, memd[ds, eax + 0x3e]);         /* mov eax, [eax+0x3e] */
            ii(0x100d_5e9b, 5); call(0x100d_5104, -0xd9c);              /* call 0x100d5104 */
            ii(0x100d_5ea0, 5); call(/* sys */ 0x1016_8de8, 0x9_2f43);  /* call 0x10168de8 */
            ii(0x100d_5ea5, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100d_5ea9, 6); mov(memb[ds, edx + 0x101c_3934], al);   /* mov [edx+0x101c3934], al */
            ii(0x100d_5eaf, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100d_5eb3, 7); cmp(memb[ds, eax + 0x101c_3934], 0);    /* cmp byte [eax+0x101c3934], 0x0 */
            ii(0x100d_5eba, 2); if(jz(0x100d_5ed7, 0x1b)) goto l_0x100d_5ed7; /* jz 0x100d5ed7 */
            ii(0x100d_5ebc, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x100d_5ebf, 3); add(ebx, 0x52);                         /* add ebx, 0x52 */
            ii(0x100d_5ec2, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100d_5ec6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_5ec9, 6); mov(eax, memd[ds, eax + 0x8c]);         /* mov eax, [eax+0x8c] */
            ii(0x100d_5ecf, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_5ed2, 5); call(0x1012_96ae, 0x5_37d7);            /* call 0x101296ae */
        l_0x100d_5ed7:
            ii(0x100d_5ed7, 2); jmp(0x100d_5e7f, -0x5a); goto l_0x100d_5e7f; /* jmp 0x100d5e7f */
        l_0x100d_5ed9:
            ii(0x100d_5ed9, 5); mov(edx, 0x295);                        /* mov edx, 0x295 */
            ii(0x100d_5ede, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_5ee1, 3); add(eax, 0x52);                         /* add eax, 0x52 */
            ii(0x100d_5ee4, 5); call(0x1011_5c5f, 0x3_fd76);            /* call 0x10115c5f */
        l_0x100d_5ee9:
            ii(0x100d_5ee9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_5eec, 3); mov(eax, memd[ds, eax + 0x4e]);         /* mov eax, [eax+0x4e] */
            ii(0x100d_5eef, 5); call(0x100e_b226, 0x1_5332);            /* call 0x100eb226 */
            ii(0x100d_5ef4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_5ef7, 4); mov(memb[ds, eax + 0x31], 1);           /* mov byte [eax+0x31], 0x1 */
            ii(0x100d_5efb, 5); jmp(0x100d_5fff, 0xff); goto l_0x100d_5fff; /* jmp 0x100d5fff */
        l_0x100d_5f00:
            ii(0x100d_5f00, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_5f03, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100d_5f06, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x100d_5f09, 6); mov(eax, memd[ds, eax - 0xf66]);        /* mov eax, [eax-0xf66] */
            ii(0x100d_5f0f, 5); call(0x100c_fbbe, -0x6356);             /* call 0x100cfbbe */
            ii(0x100d_5f14, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_5f17, 5); call(0x100d_5cbd, -0x25f);              /* call 0x100d5cbd */
            ii(0x100d_5f1c, 5); jmp(0x100d_5fff, 0xde); goto l_0x100d_5fff; /* jmp 0x100d5fff */
        l_0x100d_5f21:
            ii(0x100d_5f21, 7); cmp(memd[ss, ebp - 4], 0x7000);         /* cmp dword [ebp-0x4], 0x7000 */
            ii(0x100d_5f28, 2); if(jl(0x100d_5f83, 0x59)) goto l_0x100d_5f83; /* jl 0x100d5f83 */
            ii(0x100d_5f2a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_5f2d, 7); cmp(memb[ds, eax + 0x90], 0);           /* cmp byte [eax+0x90], 0x0 */
            ii(0x100d_5f34, 2); if(jnz(0x100d_5f81, 0x4b)) goto l_0x100d_5f81; /* jnz 0x100d5f81 */
            ii(0x100d_5f36, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_5f39, 7); mov(memb[ds, eax + 0x90], 1);           /* mov byte [eax+0x90], 0x1 */
            ii(0x100d_5f40, 7); add(memd[ss, ebp - 4], 0xffff_9000);    /* add dword [ebp-0x4], 0xffff9000 */
            ii(0x100d_5f47, 4); cmp(memd[ss, ebp - 4], 0xd);            /* cmp dword [ebp-0x4], 0xd */
            ii(0x100d_5f4b, 2); if(jnz(0x100d_5f5a, 0xd)) goto l_0x100d_5f5a; /* jnz 0x100d5f5a */
            ii(0x100d_5f4d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_5f50, 3); mov(eax, memd[ds, eax + 0x36]);         /* mov eax, [eax+0x36] */
            ii(0x100d_5f53, 5); call(0x100c_fbbe, -0x639a);             /* call 0x100cfbbe */
            ii(0x100d_5f58, 2); jmp(0x100d_5f81, 0x27); goto l_0x100d_5f81; /* jmp 0x100d5f81 */
        l_0x100d_5f5a:
            ii(0x100d_5f5a, 7); cmp(memd[ss, ebp - 4], 0x3e8);          /* cmp dword [ebp-0x4], 0x3e8 */
            ii(0x100d_5f61, 2); if(jnz(0x100d_5f70, 0xd)) goto l_0x100d_5f70; /* jnz 0x100d5f70 */
            ii(0x100d_5f63, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_5f66, 3); mov(eax, memd[ds, eax + 0x3a]);         /* mov eax, [eax+0x3a] */
            ii(0x100d_5f69, 5); call(0x100c_fbbe, -0x63b0);             /* call 0x100cfbbe */
            ii(0x100d_5f6e, 2); jmp(0x100d_5f81, 0x11); goto l_0x100d_5f81; /* jmp 0x100d5f81 */
        l_0x100d_5f70:
            ii(0x100d_5f70, 4); cmp(memd[ss, ebp - 4], 0x1b);           /* cmp dword [ebp-0x4], 0x1b */
            ii(0x100d_5f74, 2); if(jnz(0x100d_5f81, 0xb)) goto l_0x100d_5f81; /* jnz 0x100d5f81 */
            ii(0x100d_5f76, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_5f79, 3); mov(eax, memd[ds, eax + 0x32]);         /* mov eax, [eax+0x32] */
            ii(0x100d_5f7c, 5); call(0x100c_fbbe, -0x63c3);             /* call 0x100cfbbe */
        l_0x100d_5f81:
            ii(0x100d_5f81, 2); jmp(0x100d_5f91, 0xe); goto l_0x100d_5f91; /* jmp 0x100d5f91 */
        l_0x100d_5f83:
            ii(0x100d_5f83, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100d_5f86, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_5f89, 3); mov(eax, memd[ds, eax + 0x4e]);         /* mov eax, [eax+0x4e] */
            ii(0x100d_5f8c, 5); call(0x100e_b283, 0x1_52f2);            /* call 0x100eb283 */
        l_0x100d_5f91:
            ii(0x100d_5f91, 2); jmp(0x100d_5fff, 0x6c); goto l_0x100d_5fff; /* jmp 0x100d5fff */
        l_0x100d_5f93:
            ii(0x100d_5f93, 7); cmp(memd[ss, ebp - 0x14], 0x119);       /* cmp dword [ebp-0x14], 0x119 */
            ii(0x100d_5f9a, 2); if(jb(0x100d_5fdb, 0x3f)) goto l_0x100d_5fdb; /* jb 0x100d5fdb */
            ii(0x100d_5f9c, 7); cmp(memd[ss, ebp - 0x14], 0x119);       /* cmp dword [ebp-0x14], 0x119 */
            ii(0x100d_5fa3, 6); if(jbe(0x100d_5e44, -0x165)) goto l_0x100d_5e44; /* jbe 0x100d5e44 */
            ii(0x100d_5fa9, 7); cmp(memd[ss, ebp - 0x14], 0x3e8);       /* cmp dword [ebp-0x14], 0x3e8 */
            ii(0x100d_5fb0, 2); if(jb(0x100d_5fd6, 0x24)) goto l_0x100d_5fd6; /* jb 0x100d5fd6 */
            ii(0x100d_5fb2, 7); cmp(memd[ss, ebp - 0x14], 0x3e8);       /* cmp dword [ebp-0x14], 0x3e8 */
            ii(0x100d_5fb9, 6); if(jbe(0x100d_5e4e, -0x171)) goto l_0x100d_5e4e; /* jbe 0x100d5e4e */
            ii(0x100d_5fbf, 7); cmp(memd[ss, ebp - 0x14], 0x3ec);       /* cmp dword [ebp-0x14], 0x3ec */
            ii(0x100d_5fc6, 6); if(jbe(0x100d_5f00, -0xcc)) goto l_0x100d_5f00; /* jbe 0x100d5f00 */
            ii(0x100d_5fcc, 5); jmp(0x100d_5f21, -0xb0); goto l_0x100d_5f21; /* jmp 0x100d5f21 */
        //  ii(0x100d_5fd1, 5); jmp(0x100d_5f21, -0xb5); goto l_0x100d_5f21; /* jmp 0x100d5f21 */
        l_0x100d_5fd6:
            ii(0x100d_5fd6, 5); jmp(0x100d_5f21, -0xba); goto l_0x100d_5f21; /* jmp 0x100d5f21 */
        l_0x100d_5fdb:
            ii(0x100d_5fdb, 4); cmp(memd[ss, ebp - 0x14], 0xd);         /* cmp dword [ebp-0x14], 0xd */
            ii(0x100d_5fdf, 2); if(jb(0x100d_5ffa, 0x19)) goto l_0x100d_5ffa; /* jb 0x100d5ffa */
            ii(0x100d_5fe1, 4); cmp(memd[ss, ebp - 0x14], 0xd);         /* cmp dword [ebp-0x14], 0xd */
            ii(0x100d_5fe5, 6); if(jbe(0x100d_5e6b, -0x180)) goto l_0x100d_5e6b; /* jbe 0x100d5e6b */
            ii(0x100d_5feb, 4); cmp(memd[ss, ebp - 0x14], 0x1b);        /* cmp dword [ebp-0x14], 0x1b */
            ii(0x100d_5fef, 6); if(jz(0x100d_5ee9, -0x10c)) goto l_0x100d_5ee9; /* jz 0x100d5ee9 */
            ii(0x100d_5ff5, 5); jmp(0x100d_5f21, -0xd9); goto l_0x100d_5f21; /* jmp 0x100d5f21 */
        l_0x100d_5ffa:
            ii(0x100d_5ffa, 5); jmp(0x100d_5f21, -0xde); goto l_0x100d_5f21; /* jmp 0x100d5f21 */
        l_0x100d_5fff:
            ii(0x100d_5fff, 4); mov(memb[ss, ebp - 0xc], 1);            /* mov byte [ebp-0xc], 0x1 */
            ii(0x100d_6003, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x100d_6006, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_6008, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_6009, 1); pop(edi);                               /* pop edi */
            ii(0x100d_600a, 1); pop(esi);                               /* pop esi */
            ii(0x100d_600b, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_600c, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_600d, 1); ret();                                  /* ret */
        }
    }
}
