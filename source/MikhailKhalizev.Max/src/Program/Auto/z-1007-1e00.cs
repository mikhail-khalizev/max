using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_1e00-6f84413")]
        public void Method_1007_1e00()
        {
            ii(0x1007_1e00, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1007_1e05, 5); call(Definitions.sys_check_available_stack_size, 0xf_3f48); /* call 0x10165d52 */
            ii(0x1007_1e0a, 1); push(ebx);                              /* push ebx */
            ii(0x1007_1e0b, 1); push(ecx);                              /* push ecx */
            ii(0x1007_1e0c, 1); push(esi);                              /* push esi */
            ii(0x1007_1e0d, 1); push(edi);                              /* push edi */
            ii(0x1007_1e0e, 1); push(ebp);                              /* push ebp */
            ii(0x1007_1e0f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_1e11, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1007_1e17, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_1e1a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1007_1e1d, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1007_1e21, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x1007_1e24, 2); if(jnz(0x1007_1e2f, 9)) goto l_0x1007_1e2f; /* jnz 0x10071e2f */
            ii(0x1007_1e26, 7); mov(memd[ss, ebp - 4], 4);              /* mov dword [ebp-0x4], 0x4 */
            ii(0x1007_1e2d, 2); jmp(0x1007_1e3f, 0x10); goto l_0x1007_1e3f; /* jmp 0x10071e3f */
        l_0x1007_1e2f:
            ii(0x1007_1e2f, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1007_1e33, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x1007_1e36, 2); if(jnz(0x1007_1e3f, 7)) goto l_0x1007_1e3f; /* jnz 0x10071e3f */
            ii(0x1007_1e38, 7); mov(memd[ss, ebp - 4], 0xc);            /* mov dword [ebp-0x4], 0xc */
        l_0x1007_1e3f:
            ii(0x1007_1e3f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_1e42, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1007_1e45, 2); jmp(0x1007_1e6d, 0x26); goto l_0x1007_1e6d; /* jmp 0x10071e6d */
        l_0x1007_1e47:
            ii(0x1007_1e47, 4); imul(eax, memd[ss, ebp - 4], 3);        /* imul eax, [ebp-0x4], 0x3 */
            ii(0x1007_1e4b, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1007_1e4e, 5); jmp(0x1007_1eba, 0x67); goto l_0x1007_1eba; /* jmp 0x10071eba */
        l_0x1007_1e53:
            ii(0x1007_1e53, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_1e56, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1007_1e59, 5); jmp(0x1007_1eba, 0x5c); goto l_0x1007_1eba; /* jmp 0x10071eba */
        l_0x1007_1e5e:
            ii(0x1007_1e5e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_1e61, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1007_1e63, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1007_1e66, 5); jmp(0x1007_1eba, 0x4f); goto l_0x1007_1eba; /* jmp 0x10071eba */
        l_0x1007_1e6b:
            ii(0x1007_1e6b, 2); jmp(0x1007_1eb3, 0x46); goto l_0x1007_1eb3; /* jmp 0x10071eb3 */
        l_0x1007_1e6d:
            ii(0x1007_1e6d, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1007_1e70, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1007_1e73, 5); cmp(memw[ss, ebp - 20], 0x20);          /* cmp word [ebp-0x14], 0x20 */
            ii(0x1007_1e78, 2); if(jb(0x1007_1e9a, 0x20)) goto l_0x1007_1e9a; /* jb 0x10071e9a */
            ii(0x1007_1e7a, 5); cmp(memw[ss, ebp - 20], 0x20);          /* cmp word [ebp-0x14], 0x20 */
            ii(0x1007_1e7f, 2); if(jbe(0x1007_1e53, -0x2e)) goto l_0x1007_1e53; /* jbe 0x10071e53 */
            ii(0x1007_1e81, 5); cmp(memw[ss, ebp - 20], 0x31);          /* cmp word [ebp-0x14], 0x31 */
            ii(0x1007_1e86, 2); if(jb(0x1007_1e98, 0x10)) goto l_0x1007_1e98; /* jb 0x10071e98 */
            ii(0x1007_1e88, 5); cmp(memw[ss, ebp - 20], 0x31);          /* cmp word [ebp-0x14], 0x31 */
            ii(0x1007_1e8d, 2); if(jbe(0x1007_1e5e, -0x31)) goto l_0x1007_1e5e; /* jbe 0x10071e5e */
            ii(0x1007_1e8f, 5); cmp(memw[ss, ebp - 20], 0x3d);          /* cmp word [ebp-0x14], 0x3d */
            ii(0x1007_1e94, 2); if(jz(0x1007_1e5e, -0x38)) goto l_0x1007_1e5e; /* jz 0x10071e5e */
            ii(0x1007_1e96, 2); jmp(0x1007_1e6b, -0x2d); goto l_0x1007_1e6b; /* jmp 0x10071e6b */
        l_0x1007_1e98:
            ii(0x1007_1e98, 2); jmp(0x1007_1e6b, -0x2f); goto l_0x1007_1e6b; /* jmp 0x10071e6b */
        l_0x1007_1e9a:
            ii(0x1007_1e9a, 5); cmp(memw[ss, ebp - 20], 0x17);          /* cmp word [ebp-0x14], 0x17 */
            ii(0x1007_1e9f, 2); if(jb(0x1007_1eb1, 0x10)) goto l_0x1007_1eb1; /* jb 0x10071eb1 */
            ii(0x1007_1ea1, 5); cmp(memw[ss, ebp - 20], 0x19);          /* cmp word [ebp-0x14], 0x19 */
            ii(0x1007_1ea6, 2); if(jbe(0x1007_1e47, -0x61)) goto l_0x1007_1e47; /* jbe 0x10071e47 */
            ii(0x1007_1ea8, 5); cmp(memw[ss, ebp - 20], 0x1b);          /* cmp word [ebp-0x14], 0x1b */
            ii(0x1007_1ead, 2); if(jz(0x1007_1e47, -0x68)) goto l_0x1007_1e47; /* jz 0x10071e47 */
            ii(0x1007_1eaf, 2); jmp(0x1007_1e6b, -0x46); goto l_0x1007_1e6b; /* jmp 0x10071e6b */
        l_0x1007_1eb1:
            ii(0x1007_1eb1, 2); jmp(0x1007_1e6b, -0x48); goto l_0x1007_1e6b; /* jmp 0x10071e6b */
        l_0x1007_1eb3:
            ii(0x1007_1eb3, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
        l_0x1007_1eba:
            ii(0x1007_1eba, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1007_1ebd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_1ebf, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_1ec0, 1); pop(edi);                               /* pop edi */
            ii(0x1007_1ec1, 1); pop(esi);                               /* pop esi */
            ii(0x1007_1ec2, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_1ec3, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_1ec4, 1); ret();                                  /* ret */
        }
    }
}
