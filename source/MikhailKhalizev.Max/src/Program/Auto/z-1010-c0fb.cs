using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_c0fb-7a0660f")]
        public void Method_1010_c0fb()
        {
            ii(0x1010_c0fb, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1010_c100, 5); call(Definitions.sys_check_available_stack_size, 0x5_9c4d); /* call 0x10165d52 */
            ii(0x1010_c105, 1); push(ebx);                              /* push ebx */
            ii(0x1010_c106, 1); push(ecx);                              /* push ecx */
            ii(0x1010_c107, 1); push(edx);                              /* push edx */
            ii(0x1010_c108, 1); push(esi);                              /* push esi */
            ii(0x1010_c109, 1); push(edi);                              /* push edi */
            ii(0x1010_c10a, 1); push(ebp);                              /* push ebp */
            ii(0x1010_c10b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_c10d, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1010_c113, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1010_c116, 7); mov(memd[ss, ebp - 8], 0x1e0);          /* mov dword [ebp-0x8], 0x1e0 */
        l_0x1010_c11d:
            ii(0x1010_c11d, 3); dec(memd[ss, ebp - 8]);                 /* dec dword [ebp-0x8] */
            ii(0x1010_c120, 4); cmp(memd[ss, ebp - 8], -1 /* 0xff */);  /* cmp dword [ebp-0x8], 0xffffffff */
            ii(0x1010_c124, 2); if(jz(0x1010_c163, 0x3d)) goto l_0x1010_c163; /* jz 0x1010c163 */
            ii(0x1010_c126, 7); imul(eax, memd[ss, ebp - 8], 0x280);    /* imul eax, [ebp-0x8], 0x280 */
            ii(0x1010_c12d, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_c130, 7); test(memd[ss, ebp - 8], 1);             /* test dword [ebp-0x8], 0x1 */
            ii(0x1010_c137, 2); if(jz(0x1010_c13f, 6)) goto l_0x1010_c13f; /* jz 0x1010c13f */
            ii(0x1010_c139, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_c13c, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
        l_0x1010_c13f:
            ii(0x1010_c13f, 7); mov(memd[ss, ebp - 0xc], 0x140);        /* mov dword [ebp-0xc], 0x140 */
        l_0x1010_c146:
            ii(0x1010_c146, 3); dec(memd[ss, ebp - 0xc]);               /* dec dword [ebp-0xc] */
            ii(0x1010_c149, 4); cmp(memd[ss, ebp - 0xc], -1 /* 0xff */); /* cmp dword [ebp-0xc], 0xffffffff */
            ii(0x1010_c14d, 2); if(jz(0x1010_c161, 0x12)) goto l_0x1010_c161; /* jz 0x1010c161 */
            ii(0x1010_c14f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_c152, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x1010_c155, 3); add(eax, memd[ss, ebp - 0x10]);         /* add eax, [ebp-0x10] */
            ii(0x1010_c158, 3); mov(memb[ds, eax], 0);                  /* mov byte [eax], 0x0 */
            ii(0x1010_c15b, 4); add(memd[ss, ebp - 0x10], 2);           /* add dword [ebp-0x10], 0x2 */
            ii(0x1010_c15f, 2); jmp(0x1010_c146, -0x1b); goto l_0x1010_c146; /* jmp 0x1010c146 */
        l_0x1010_c161:
            ii(0x1010_c161, 2); jmp(0x1010_c11d, -0x46); goto l_0x1010_c11d; /* jmp 0x1010c11d */
        l_0x1010_c163:
            ii(0x1010_c163, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_c165, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_c166, 1); pop(edi);                               /* pop edi */
            ii(0x1010_c167, 1); pop(esi);                               /* pop esi */
            ii(0x1010_c168, 1); pop(edx);                               /* pop edx */
            ii(0x1010_c169, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_c16a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_c16b, 1); ret();                                  /* ret */
        }
    }
}
