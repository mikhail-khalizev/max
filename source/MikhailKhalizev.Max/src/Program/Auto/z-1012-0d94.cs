using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_0d94-12d161fe")]
        public void Method_1012_0d94()
        {
            ii(0x1012_0d94, 5); push(0x34);                             /* push 0x34 */
            ii(0x1012_0d99, 5); call(Definitions.sys_check_available_stack_size, 0x4_4fb4); /* call 0x10165d52 */
            ii(0x1012_0d9e, 1); push(ebx);                              /* push ebx */
            ii(0x1012_0d9f, 1); push(ecx);                              /* push ecx */
            ii(0x1012_0da0, 1); push(edx);                              /* push edx */
            ii(0x1012_0da1, 1); push(esi);                              /* push esi */
            ii(0x1012_0da2, 1); push(edi);                              /* push edi */
            ii(0x1012_0da3, 1); push(ebp);                              /* push ebp */
            ii(0x1012_0da4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0da6, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1012_0dac, 3); mov(memb[ss, ebp - 4], al);             /* mov [ebp-0x4], al */
            ii(0x1012_0daf, 5); mov(al, memb[ds, 0x101c_5620]);         /* mov al, [0x101c5620] */
            ii(0x1012_0db4, 3); cmp(al, memb[ss, ebp - 4]);             /* cmp al, [ebp-0x4] */
            ii(0x1012_0db7, 6); if(jz(0x1012_0ec4, 0x107)) goto l_0x1012_0ec4; /* jz 0x10120ec4 */
            ii(0x1012_0dbd, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1012_0dc1, 3); imul(eax, eax, 0x16);                   /* imul eax, eax, 0x16 */
            ii(0x1012_0dc4, 7); cmp(memd[ds, eax + 0x101c_539e], 0);    /* cmp dword [eax+0x101c539e], 0x0 */
            ii(0x1012_0dcb, 6); if(jz(0x1012_0ebc, 0xeb)) goto l_0x1012_0ebc; /* jz 0x10120ebc */
            ii(0x1012_0dd1, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1012_0dd5, 3); imul(eax, eax, 0x16);                   /* imul eax, eax, 0x16 */
            ii(0x1012_0dd8, 6); mov(eax, memd[ds, eax + 0x101c_539a]);  /* mov eax, [eax+0x101c539a] */
            ii(0x1012_0dde, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_0de1, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1012_0de4, 2); if(jle(0x1012_0e57, 0x71)) goto l_0x1012_0e57; /* jle 0x10120e57 */
            ii(0x1012_0de6, 5); push(0xc8);                             /* push 0xc8 */
            ii(0x1012_0deb, 4); movsx(ecx, memb[ss, ebp - 4]);          /* movsx ecx, byte [ebp-0x4] */
            ii(0x1012_0def, 3); imul(ecx, ecx, 0x16);                   /* imul ecx, ecx, 0x16 */
            ii(0x1012_0df2, 6); mov(ecx, memd[ds, ecx + 0x101c_539e]);  /* mov ecx, [ecx+0x101c539e] */
            ii(0x1012_0df8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_0dfa, 2); mov(al, memb[ds, ecx]);                 /* mov al, [ecx] */
            ii(0x1012_0dfc, 1); push(eax);                              /* push eax */
            ii(0x1012_0dfd, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1012_0e01, 3); imul(eax, eax, 0x16);                   /* imul eax, eax, 0x16 */
            ii(0x1012_0e04, 6); push(memd[ds, eax + 0x101c_5398]);      /* push dword [eax+0x101c5398] */
            ii(0x1012_0e0a, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1012_0e0e, 3); imul(eax, eax, 0x16);                   /* imul eax, eax, 0x16 */
            ii(0x1012_0e11, 6); push(memd[ds, eax + 0x101c_5394]);      /* push dword [eax+0x101c5394] */
            ii(0x1012_0e17, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1012_0e1b, 3); imul(eax, eax, 0x16);                   /* imul eax, eax, 0x16 */
            ii(0x1012_0e1e, 6); push(memd[ds, eax + 0x101c_538c]);      /* push dword [eax+0x101c538c] */
            ii(0x1012_0e24, 4); movsx(ecx, memb[ss, ebp - 4]);          /* movsx ecx, byte [ebp-0x4] */
            ii(0x1012_0e28, 3); imul(ecx, ecx, 0x16);                   /* imul ecx, ecx, 0x16 */
            ii(0x1012_0e2b, 6); mov(ecx, memd[ds, ecx + 0x101c_5390]);  /* mov ecx, [ecx+0x101c5390] */
            ii(0x1012_0e31, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_0e33, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1012_0e37, 3); imul(eax, eax, 0x16);                   /* imul eax, eax, 0x16 */
            ii(0x1012_0e3a, 6); mov(edx, memd[ds, eax + 0x101c_539a]);  /* mov edx, [eax+0x101c539a] */
            ii(0x1012_0e40, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_0e43, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1012_0e47, 3); imul(eax, eax, 0x16);                   /* imul eax, eax, 0x16 */
            ii(0x1012_0e4a, 6); mov(eax, memd[ds, eax + 0x101c_539e]);  /* mov eax, [eax+0x101c539e] */
            ii(0x1012_0e50, 5); call(/* sys */ 0x1016_bbe8, 0x4_ad93);  /* call 0x1016bbe8 */
            ii(0x1012_0e55, 2); jmp(0x1012_0ebc, 0x65); goto l_0x1012_0ebc; /* jmp 0x10120ebc */
        l_0x1012_0e57:
            ii(0x1012_0e57, 4); movsx(ecx, memb[ss, ebp - 4]);          /* movsx ecx, byte [ebp-0x4] */
            ii(0x1012_0e5b, 3); imul(ecx, ecx, 0x16);                   /* imul ecx, ecx, 0x16 */
            ii(0x1012_0e5e, 6); mov(ecx, memd[ds, ecx + 0x101c_539e]);  /* mov ecx, [ecx+0x101c539e] */
            ii(0x1012_0e64, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_0e66, 2); mov(al, memb[ds, ecx]);                 /* mov al, [ecx] */
            ii(0x1012_0e68, 1); push(eax);                              /* push eax */
            ii(0x1012_0e69, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1012_0e6d, 3); imul(eax, eax, 0x16);                   /* imul eax, eax, 0x16 */
            ii(0x1012_0e70, 6); push(memd[ds, eax + 0x101c_5398]);      /* push dword [eax+0x101c5398] */
            ii(0x1012_0e76, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1012_0e7a, 3); imul(eax, eax, 0x16);                   /* imul eax, eax, 0x16 */
            ii(0x1012_0e7d, 6); push(memd[ds, eax + 0x101c_5394]);      /* push dword [eax+0x101c5394] */
            ii(0x1012_0e83, 4); movsx(ecx, memb[ss, ebp - 4]);          /* movsx ecx, byte [ebp-0x4] */
            ii(0x1012_0e87, 3); imul(ecx, ecx, 0x16);                   /* imul ecx, ecx, 0x16 */
            ii(0x1012_0e8a, 6); mov(ecx, memd[ds, ecx + 0x101c_538c]);  /* mov ecx, [ecx+0x101c538c] */
            ii(0x1012_0e90, 4); movsx(ebx, memb[ss, ebp - 4]);          /* movsx ebx, byte [ebp-0x4] */
            ii(0x1012_0e94, 3); imul(ebx, ebx, 0x16);                   /* imul ebx, ebx, 0x16 */
            ii(0x1012_0e97, 6); mov(ebx, memd[ds, ebx + 0x101c_5390]);  /* mov ebx, [ebx+0x101c5390] */
            ii(0x1012_0e9d, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1012_0ea1, 3); imul(eax, eax, 0x16);                   /* imul eax, eax, 0x16 */
            ii(0x1012_0ea4, 6); mov(edx, memd[ds, eax + 0x101c_538c]);  /* mov edx, [eax+0x101c538c] */
            ii(0x1012_0eaa, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1012_0eae, 3); imul(eax, eax, 0x16);                   /* imul eax, eax, 0x16 */
            ii(0x1012_0eb1, 6); mov(eax, memd[ds, eax + 0x101c_539e]);  /* mov eax, [eax+0x101c539e] */
            ii(0x1012_0eb7, 5); call(/* sys */ 0x1016_ba3c, 0x4_ab80);  /* call 0x1016ba3c */
        l_0x1012_0ebc:
            ii(0x1012_0ebc, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1012_0ebf, 5); mov(memb[ds, 0x101c_5620], al);         /* mov [0x101c5620], al */
        l_0x1012_0ec4:
            ii(0x1012_0ec4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_0ec6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_0ec7, 1); pop(edi);                               /* pop edi */
            ii(0x1012_0ec8, 1); pop(esi);                               /* pop esi */
            ii(0x1012_0ec9, 1); pop(edx);                               /* pop edx */
            ii(0x1012_0eca, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_0ecb, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_0ecc, 1); ret();                                  /* ret */
        }
    }
}
