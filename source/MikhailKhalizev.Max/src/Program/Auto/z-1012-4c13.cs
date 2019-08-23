using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_4c13-85e8e59e")]
        public void Method_1012_4c13()
        {
            ii(0x1012_4c13, 5); push(0x254);                            /* push 0x254 */
            ii(0x1012_4c18, 5); call(Definitions.sys_check_available_stack_size, 0x4_1135); /* call 0x10165d52 */
            ii(0x1012_4c1d, 1); push(ebx);                              /* push ebx */
            ii(0x1012_4c1e, 1); push(ecx);                              /* push ecx */
            ii(0x1012_4c1f, 1); push(edx);                              /* push edx */
            ii(0x1012_4c20, 1); push(esi);                              /* push esi */
            ii(0x1012_4c21, 1); push(edi);                              /* push edi */
            ii(0x1012_4c22, 1); push(ebp);                              /* push ebp */
            ii(0x1012_4c23, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_4c25, 6); sub(esp, 0x238);                        /* sub esp, 0x238 */
            ii(0x1012_4c2b, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
        l_0x1012_4c2e:
            ii(0x1012_4c2e, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1012_4c35, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1012_4c39, 7); mov(memb[ss, ebp - 0x238], 0);          /* mov byte [ebp-0x238], 0x0 */
        l_0x1012_4c40:
            ii(0x1012_4c40, 4); cmp(memd[ss, ebp - 0x10], 0xa);         /* cmp dword [ebp-0x10], 0xa */
            ii(0x1012_4c44, 6); if(jz(0x1012_4d44, 0xfa)) goto l_0x1012_4d44; /* jz 0x10124d44 */
            ii(0x1012_4c4a, 5); call(0x1012_4ba2, -0xad);               /* call 0x10124ba2 */
            ii(0x1012_4c4f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_4c54, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_4c57, 4); cmp(memd[ss, ebp - 0x10], 0xd);         /* cmp dword [ebp-0x10], 0xd */
            ii(0x1012_4c5b, 2); if(jnz(0x1012_4c64, 0x7)) goto l_0x1012_4c64; /* jnz 0x10124c64 */
            ii(0x1012_4c5d, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x1012_4c64:
            ii(0x1012_4c64, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_4c66, 6); mov(al, memb[ss, ebp - 0x238]);         /* mov al, [ebp-0x238] */
            ii(0x1012_4c6c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_4c6e, 2); if(jnz(0x1012_4c76, 0x6)) goto l_0x1012_4c76; /* jnz 0x10124c76 */
            ii(0x1012_4c70, 4); cmp(memd[ss, ebp - 0x10], 0xa);         /* cmp dword [ebp-0x10], 0xa */
            ii(0x1012_4c74, 2); if(jz(0x1012_4c78, 0x2)) goto l_0x1012_4c78; /* jz 0x10124c78 */
        l_0x1012_4c76:
            ii(0x1012_4c76, 2); jmp(0x1012_4c7f, 0x7); goto l_0x1012_4c7f; /* jmp 0x10124c7f */
        l_0x1012_4c78:
            ii(0x1012_4c78, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x1012_4c7f:
            ii(0x1012_4c7f, 4); cmp(memd[ss, ebp - 0x10], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1012_4c83, 2); if(jz(0x1012_4cc1, 0x3c)) goto l_0x1012_4cc1; /* jz 0x10124cc1 */
            ii(0x1012_4c85, 4); cmp(memd[ss, ebp - 0x10], 0xa);         /* cmp dword [ebp-0x10], 0xa */
            ii(0x1012_4c89, 2); if(jnz(0x1012_4c95, 0xa)) goto l_0x1012_4c95; /* jnz 0x10124c95 */
            ii(0x1012_4c8b, 8); add(memw[ds, 0x101c_59c6], 0xc);        /* add word [0x101c59c6], 0xc */
            ii(0x1012_4c93, 2); jmp(0x1012_4cbc, 0x27); goto l_0x1012_4cbc; /* jmp 0x10124cbc */
        l_0x1012_4c95:
            ii(0x1012_4c95, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1012_4c9a, 3); lea(edx, memd[ss, ebp - 0x10]);         /* lea edx, [ebp-0x10] */
            ii(0x1012_4c9d, 6); lea(eax, memd[ss, ebp - 0x238]);        /* lea eax, [ebp-0x238] */
            ii(0x1012_4ca3, 5); call(/* sys */ 0x1017_d4f2, 0x5_884a);  /* call 0x1017d4f2 */
            ii(0x1012_4ca8, 7); cmp(memb[ds, 0x101c_5630], 0);          /* cmp byte [0x101c5630], 0x0 */
            ii(0x1012_4caf, 2); if(jnz(0x1012_4cbc, 0xb)) goto l_0x1012_4cbc; /* jnz 0x10124cbc */
            ii(0x1012_4cb1, 6); lea(eax, memd[ss, ebp - 0x238]);        /* lea eax, [ebp-0x238] */
            ii(0x1012_4cb7, 5); call(0x1012_4b19, -0x1a3);              /* call 0x10124b19 */
        l_0x1012_4cbc:
            ii(0x1012_4cbc, 5); jmp(0x1012_4d3f, 0x7e); goto l_0x1012_4d3f; /* jmp 0x10124d3f */
        l_0x1012_4cc1:
            ii(0x1012_4cc1, 5); call(/* sys */ 0x1016_b208, 0x4_6542);  /* call 0x1016b208 */
            ii(0x1012_4cc6, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_4cc9, 7); cmp(memd[ss, ebp - 0x10], 0x7000);      /* cmp dword [ebp-0x10], 0x7000 */
            ii(0x1012_4cd0, 2); if(jnz(0x1012_4cdb, 0x9)) goto l_0x1012_4cdb; /* jnz 0x10124cdb */
            ii(0x1012_4cd2, 7); cmp(memd[ds, 0x101c_4df0], 0);          /* cmp dword [0x101c4df0], 0x0 */
            ii(0x1012_4cd9, 2); if(jnz(0x1012_4cdd, 0x2)) goto l_0x1012_4cdd; /* jnz 0x10124cdd */
        l_0x1012_4cdb:
            ii(0x1012_4cdb, 2); jmp(0x1012_4ce6, 0x9); goto l_0x1012_4ce6; /* jmp 0x10124ce6 */
        l_0x1012_4cdd:
            ii(0x1012_4cdd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_4cdf, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1012_4ce2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_4ce4, 2); if(jz(0x1012_4ce8, 0x2)) goto l_0x1012_4ce8; /* jz 0x10124ce8 */
        l_0x1012_4ce6:
            ii(0x1012_4ce6, 2); jmp(0x1012_4cf8, 0x10); goto l_0x1012_4cf8; /* jmp 0x10124cf8 */
        l_0x1012_4ce8:
            ii(0x1012_4ce8, 5); mov(eax, memd[ds, 0x101c_4df0]);        /* mov eax, [0x101c4df0] */
            ii(0x1012_4ced, 5); call(0x100c_fbbe, -0x5_5134);           /* call 0x100cfbbe */
            ii(0x1012_4cf2, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x1012_4cf6, 2); jmp(0x1012_4d3f, 0x47); goto l_0x1012_4d3f; /* jmp 0x10124d3f */
        l_0x1012_4cf8:
            ii(0x1012_4cf8, 4); cmp(memd[ss, ebp - 0x10], 0x1b);        /* cmp dword [ebp-0x10], 0x1b */
            ii(0x1012_4cfc, 2); if(jnz(0x1012_4d2a, 0x2c)) goto l_0x1012_4d2a; /* jnz 0x10124d2a */
            ii(0x1012_4cfe, 7); cmp(memb[ds, 0x101c_5630], 0);          /* cmp byte [0x101c5630], 0x0 */
            ii(0x1012_4d05, 2); if(jnz(0x1012_4d21, 0x1a)) goto l_0x1012_4d21; /* jnz 0x10124d21 */
            ii(0x1012_4d07, 8); add(memw[ds, 0x101c_59c6], 0xc);        /* add word [0x101c59c6], 0xc */
            ii(0x1012_4d0f, 5); mov(eax, StringDefinitions.CommandTerminated); /* mov eax, 0x101a8170 */
            ii(0x1012_4d14, 5); call(0x1012_4b19, -0x200);              /* call 0x10124b19 */
            ii(0x1012_4d19, 8); add(memw[ds, 0x101c_59c6], 0xc);        /* add word [0x101c59c6], 0xc */
        l_0x1012_4d21:
            ii(0x1012_4d21, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1012_4d28, 2); jmp(0x1012_4d7e, 0x54); goto l_0x1012_4d7e; /* jmp 0x10124d7e */
        l_0x1012_4d2a:
            ii(0x1012_4d2a, 4); cmp(memd[ss, ebp - 0x10], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1012_4d2e, 2); if(jle(0x1012_4d39, 0x9)) goto l_0x1012_4d39; /* jle 0x10124d39 */
            ii(0x1012_4d30, 7); cmp(memd[ss, ebp - 0x10], 0x7000);      /* cmp dword [ebp-0x10], 0x7000 */
            ii(0x1012_4d37, 2); if(jl(0x1012_4d3b, 0x2)) goto l_0x1012_4d3b; /* jl 0x10124d3b */
        l_0x1012_4d39:
            ii(0x1012_4d39, 2); jmp(0x1012_4d3f, 0x4); goto l_0x1012_4d3f; /* jmp 0x10124d3f */
        l_0x1012_4d3b:
            ii(0x1012_4d3b, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
        l_0x1012_4d3f:
            ii(0x1012_4d3f, 5); jmp(0x1012_4c40, -0x104); goto l_0x1012_4c40; /* jmp 0x10124c40 */
        l_0x1012_4d44:
            ii(0x1012_4d44, 4); cmp(memd[ss, ebp - 0x4], 0);            /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1012_4d48, 2); if(jz(0x1012_4d66, 0x1c)) goto l_0x1012_4d66; /* jz 0x10124d66 */
            ii(0x1012_4d4a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_4d4d, 5); call(Definitions.sys_strlen, 0x4_d175); /* call 0x10171ec7 */
            ii(0x1012_4d52, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1012_4d54, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1012_4d57, 6); lea(eax, memd[ss, ebp - 0x238]);        /* lea eax, [ebp-0x238] */
            ii(0x1012_4d5d, 5); call(/* sys */ 0x1017_d531, 0x5_87cf);  /* call 0x1017d531 */
            ii(0x1012_4d62, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_4d64, 2); if(jnz(0x1012_4d79, 0x13)) goto l_0x1012_4d79; /* jnz 0x10124d79 */
        l_0x1012_4d66:
            ii(0x1012_4d66, 5); mov(eax, 0x12_34dc);                    /* mov eax, 0x1234dc */
            ii(0x1012_4d6b, 5); call(0x1014_8574, 0x2_3804);            /* call 0x10148574 */
            ii(0x1012_4d70, 7); mov(memd[ss, ebp - 0x8], 0x1);          /* mov dword [ebp-0x8], 0x1 */
            ii(0x1012_4d77, 2); jmp(0x1012_4d7e, 0x5); goto l_0x1012_4d7e; /* jmp 0x10124d7e */
        l_0x1012_4d79:
            ii(0x1012_4d79, 5); jmp(0x1012_4c2e, -0x150); goto l_0x1012_4c2e; /* jmp 0x10124c2e */
        l_0x1012_4d7e:
            ii(0x1012_4d7e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_4d81, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_4d83, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_4d84, 1); pop(edi);                               /* pop edi */
            ii(0x1012_4d85, 1); pop(esi);                               /* pop esi */
            ii(0x1012_4d86, 1); pop(edx);                               /* pop edx */
            ii(0x1012_4d87, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_4d88, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_4d89, 1); ret();                                  /* ret */
        }
    }
}
