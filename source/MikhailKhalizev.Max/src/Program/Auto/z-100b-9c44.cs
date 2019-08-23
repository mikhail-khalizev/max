using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_9c44-585e1e40")]
        public void Method_100b_9c44()
        {
            ii(0x100b_9c44, 5); push(0x30);                             /* push 0x30 */
            ii(0x100b_9c49, 5); call(Definitions.sys_check_available_stack_size, 0xa_c104); /* call 0x10165d52 */
            ii(0x100b_9c4e, 1); push(ebx);                              /* push ebx */
            ii(0x100b_9c4f, 1); push(ecx);                              /* push ecx */
            ii(0x100b_9c50, 1); push(esi);                              /* push esi */
            ii(0x100b_9c51, 1); push(edi);                              /* push edi */
            ii(0x100b_9c52, 1); push(ebp);                              /* push ebp */
            ii(0x100b_9c53, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_9c55, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100b_9c5b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_9c5e, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_9c61, 4); or(memb[ss, ebp - 0xc], 0x1);           /* or byte [ebp-0xc], 0x1 */
            ii(0x100b_9c65, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_9c68, 5); call(0x1007_64fc, -0x4_3771);           /* call 0x100764fc */
            ii(0x100b_9c6d, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100b_9c70, 4); and(memb[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100b_9c74, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_9c76, 5); mov(al, memb[ds, 0x101c_37c9]);         /* mov al, [0x101c37c9] */
            ii(0x100b_9c7b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_9c7d, 2); if(jnz(0x100b_9c91, 0x12)) goto l_0x100b_9c91; /* jnz 0x100b9c91 */
            ii(0x100b_9c7f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_9c82, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100b_9c85, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9c87, 6); mov(dl, memb[ds, 0x101c_37c8]);         /* mov dl, [0x101c37c8] */
            ii(0x100b_9c8d, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_9c8f, 2); if(jnz(0x100b_9c9a, 0x9)) goto l_0x100b_9c9a; /* jnz 0x100b9c9a */
        l_0x100b_9c91:
            ii(0x100b_9c91, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100b_9c98, 2); jmp(0x100b_9cb3, 0x19); goto l_0x100b_9cb3; /* jmp 0x100b9cb3 */
        l_0x100b_9c9a:
            ii(0x100b_9c9a, 5); mov(ecx, 0x1e0);                        /* mov ecx, 0x1e0 */
            ii(0x100b_9c9f, 5); mov(ebx, StringDefinitions.AiPlayrCpp3); /* mov ebx, 0x101a128c */
            ii(0x100b_9ca4, 5); mov(edx, StringDefinitions.PlaymodeNotEqualTurnBasedTeamturnidEqualTeam6); /* mov edx, 0x101a1299 */
            ii(0x100b_9ca9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_9cab, 5); call(Definitions.sys_assert, 0xa_c0e2); /* call 0x10165d92 */
            ii(0x100b_9cb0, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x100b_9cb3:
            ii(0x100b_9cb3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_9cb6, 5); call(0x1007_6338, -0x4_3983);           /* call 0x10076338 */
            ii(0x100b_9cbb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_9cbd, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_9cc0, 5); call(0x1007_643c, -0x4_3889);           /* call 0x1007643c */
            ii(0x100b_9cc5, 2); jmp(0x100b_9ccf, 0x8); goto l_0x100b_9ccf; /* jmp 0x100b9ccf */
        l_0x100b_9cc7:
            ii(0x100b_9cc7, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_9cca, 5); call(0x1007_6bf8, -0x4_30d7);           /* call 0x10076bf8 */
        l_0x100b_9ccf:
            ii(0x100b_9ccf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9cd1, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_9cd4, 5); call(0x1013_ad71, 0x8_1098);            /* call 0x1013ad71 */
            ii(0x100b_9cd9, 2); test(al, al);                           /* test al, al */
            ii(0x100b_9cdb, 6); if(jz(0x100b_9d92, 0xb1)) goto l_0x100b_9d92; /* jz 0x100b9d92 */
            ii(0x100b_9ce1, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_9ce4, 5); call(0x1007_63a0, -0x4_3949);           /* call 0x100763a0 */
            ii(0x100b_9ce9, 4); cmp(memb[ds, eax + 0x3d], 0x2);         /* cmp byte [eax+0x3d], 0x2 */
            ii(0x100b_9ced, 2); if(jz(0x100b_9cfd, 0xe)) goto l_0x100b_9cfd; /* jz 0x100b9cfd */
            ii(0x100b_9cef, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_9cf2, 5); call(0x1007_63a0, -0x4_3957);           /* call 0x100763a0 */
            ii(0x100b_9cf7, 4); cmp(memb[ds, eax + 0x3d], 0x1b);        /* cmp byte [eax+0x3d], 0x1b */
            ii(0x100b_9cfb, 2); if(jnz(0x100b_9cff, 0x2)) goto l_0x100b_9cff; /* jnz 0x100b9cff */
        l_0x100b_9cfd:
            ii(0x100b_9cfd, 2); jmp(0x100b_9d0d, 0xe); goto l_0x100b_9d0d; /* jmp 0x100b9d0d */
        l_0x100b_9cff:
            ii(0x100b_9cff, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_9d02, 5); call(0x1007_63a0, -0x4_3967);           /* call 0x100763a0 */
            ii(0x100b_9d07, 4); cmp(memb[ds, eax + 0x3d], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x100b_9d0b, 2); if(jnz(0x100b_9d1b, 0xe)) goto l_0x100b_9d1b; /* jnz 0x100b9d1b */
        l_0x100b_9d0d:
            ii(0x100b_9d0d, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_9d10, 5); call(0x1007_63a0, -0x4_3975);           /* call 0x100763a0 */
            ii(0x100b_9d15, 4); cmp(memb[ds, eax + 0x3e], 0x1);         /* cmp byte [eax+0x3e], 0x1 */
            ii(0x100b_9d19, 2); if(jz(0x100b_9d1d, 0x2)) goto l_0x100b_9d1d; /* jz 0x100b9d1d */
        l_0x100b_9d1b:
            ii(0x100b_9d1b, 2); jmp(0x100b_9d34, 0x17); goto l_0x100b_9d34; /* jmp 0x100b9d34 */
        l_0x100b_9d1d:
            ii(0x100b_9d1d, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_9d20, 5); call(0x1007_63a0, -0x4_3985);           /* call 0x100763a0 */
            ii(0x100b_9d25, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9d27, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x100b_9d2a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_9d2d, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100b_9d30, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_9d32, 2); if(jz(0x100b_9d36, 0x2)) goto l_0x100b_9d36; /* jz 0x100b9d36 */
        l_0x100b_9d34:
            ii(0x100b_9d34, 2); jmp(0x100b_9d44, 0xe); goto l_0x100b_9d44; /* jmp 0x100b9d44 */
        l_0x100b_9d36:
            ii(0x100b_9d36, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_9d39, 5); call(0x1007_63a0, -0x4_399e);           /* call 0x100763a0 */
            ii(0x100b_9d3e, 4); cmp(memb[ds, eax + 0x4e], 0);           /* cmp byte [eax+0x4e], 0x0 */
            ii(0x100b_9d42, 2); if(jnz(0x100b_9d46, 0x2)) goto l_0x100b_9d46; /* jnz 0x100b9d46 */
        l_0x100b_9d44:
            ii(0x100b_9d44, 2); jmp(0x100b_9d5b, 0x15); goto l_0x100b_9d5b; /* jmp 0x100b9d5b */
        l_0x100b_9d46:
            ii(0x100b_9d46, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_9d49, 5); call(0x1007_63a0, -0x4_39ae);           /* call 0x100763a0 */
            ii(0x100b_9d4e, 3); mov(al, memb[ds, eax + 0x60]);          /* mov al, [eax+0x60] */
            ii(0x100b_9d51, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_9d56, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100b_9d59, 2); if(jz(0x100b_9d5d, 0x2)) goto l_0x100b_9d5d; /* jz 0x100b9d5d */
        l_0x100b_9d5b:
            ii(0x100b_9d5b, 2); jmp(0x100b_9d6e, 0x11); goto l_0x100b_9d6e; /* jmp 0x100b9d6e */
        l_0x100b_9d5d:
            ii(0x100b_9d5d, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_9d60, 5); call(0x1007_63a0, -0x4_39c5);           /* call 0x100763a0 */
            ii(0x100b_9d65, 5); call(0x1015_26ac, 0x9_8942);            /* call 0x101526ac */
            ii(0x100b_9d6a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_9d6c, 2); if(jnz(0x100b_9d70, 0x2)) goto l_0x100b_9d70; /* jnz 0x100b9d70 */
        l_0x100b_9d6e:
            ii(0x100b_9d6e, 2); jmp(0x100b_9d8d, 0x1d); goto l_0x100b_9d8d; /* jmp 0x100b9d8d */
        l_0x100b_9d70:
            ii(0x100b_9d70, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_9d72, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_9d75, 5); call(0x1007_63a0, -0x4_39da);           /* call 0x100763a0 */
            ii(0x100b_9d7a, 3); mov(edx, memd[ds, eax + 0x3a]);         /* mov edx, [eax+0x3a] */
            ii(0x100b_9d7d, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x100b_9d80, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_9d83, 5); call(0x1007_6408, -0x4_3980);           /* call 0x10076408 */
            ii(0x100b_9d88, 5); call(0x1016_3053, 0xa_92c6);            /* call 0x10163053 */
        l_0x100b_9d8d:
            ii(0x100b_9d8d, 5); jmp(0x100b_9cc7, -0xcb); goto l_0x100b_9cc7; /* jmp 0x100b9cc7 */
        l_0x100b_9d92:
            ii(0x100b_9d92, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_9d94, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_9d97, 5); call(0x1007_5f6c, -0x4_3e30);           /* call 0x10075f6c */
            ii(0x100b_9d9c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_9d9e, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_9d9f, 1); pop(edi);                               /* pop edi */
            ii(0x100b_9da0, 1); pop(esi);                               /* pop esi */
            ii(0x100b_9da1, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_9da2, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_9da3, 1); ret();                                  /* ret */
        }
    }
}
