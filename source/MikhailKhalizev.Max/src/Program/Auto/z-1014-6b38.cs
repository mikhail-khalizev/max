using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_6b38-64bc8872")]
        public void Method_1014_6b38()
        {
            ii(0x1014_6b38, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1014_6b3d, 5); call(Definitions.sys_check_available_stack_size, 0x1_f210); /* call 0x10165d52 */
            ii(0x1014_6b42, 1); push(ebx);                              /* push ebx */
            ii(0x1014_6b43, 1); push(ecx);                              /* push ecx */
            ii(0x1014_6b44, 1); push(esi);                              /* push esi */
            ii(0x1014_6b45, 1); push(edi);                              /* push edi */
            ii(0x1014_6b46, 1); push(ebp);                              /* push ebp */
            ii(0x1014_6b47, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_6b49, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_6b4f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_6b52, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_6b55, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_6b58, 5); call(0x1014_68e2, -0x27b);              /* call 0x101468e2 */
            ii(0x1014_6b5d, 2); test(al, al);                           /* test al, al */
            ii(0x1014_6b5f, 2); if(jnz(0x1014_6b67, 0x6)) goto l_0x1014_6b67; /* jnz 0x10146b67 */
            ii(0x1014_6b61, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1014_6b65, 2); jmp(0x1014_6bcc, 0x65); goto l_0x1014_6bcc; /* jmp 0x10146bcc */
        l_0x1014_6b67:
            ii(0x1014_6b67, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_6b6a, 3); mov(al, memb[ds, eax + 0x1c]);          /* mov al, [eax+0x1c] */
            ii(0x1014_6b6d, 2); inc(al);                                /* inc al */
            ii(0x1014_6b6f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_6b74, 7); test(memb[ds, eax + 0x101b_75c0], 0xc0); /* test byte [eax+0x101b75c0], 0xc0 */
            ii(0x1014_6b7b, 2); if(jnz(0x1014_6b8f, 0x12)) goto l_0x1014_6b8f; /* jnz 0x10146b8f */
            ii(0x1014_6b7d, 5); mov(eax, StringDefinitions.ExpectedALetter); /* mov eax, 0x101ad053 */
            ii(0x1014_6b82, 1); push(eax);                              /* push eax */
            ii(0x1014_6b83, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_6b86, 1); push(eax);                              /* push eax */
            ii(0x1014_6b87, 5); call(0x1014_69b5, -0x1d7);              /* call 0x101469b5 */
            ii(0x1014_6b8c, 3); add(esp, 0x8);                          /* add esp, 0x8 */
        l_0x1014_6b8f:
            ii(0x1014_6b8f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_6b92, 3); mov(al, memb[ds, eax + 0x1c]);          /* mov al, [eax+0x1c] */
            ii(0x1014_6b95, 2); inc(al);                                /* inc al */
            ii(0x1014_6b97, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_6b9c, 7); test(memb[ds, eax + 0x101b_75c0], 0xe0); /* test byte [eax+0x101b75c0], 0xe0 */
            ii(0x1014_6ba3, 2); if(jnz(0x1014_6bae, 0x9)) goto l_0x1014_6bae; /* jnz 0x10146bae */
            ii(0x1014_6ba5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_6ba8, 4); cmp(memd[ds, eax + 0x1c], 0x5f);        /* cmp dword [eax+0x1c], 0x5f */
            ii(0x1014_6bac, 2); if(jnz(0x1014_6bc8, 0x1a)) goto l_0x1014_6bc8; /* jnz 0x10146bc8 */
        l_0x1014_6bae:
            ii(0x1014_6bae, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_6bb1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6bb3, 3); mov(dl, memb[ds, eax + 0x1c]);          /* mov dl, [eax+0x1c] */
            ii(0x1014_6bb6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_6bb9, 5); call(Definitions.my_string_append_char, -0x4dd4); /* call 0x10141dea */
            ii(0x1014_6bbe, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_6bc1, 5); call(0x1014_6722, -0x4a4);              /* call 0x10146722 */
            ii(0x1014_6bc6, 2); jmp(0x1014_6b8f, -0x39); goto l_0x1014_6b8f; /* jmp 0x10146b8f */
        l_0x1014_6bc8:
            ii(0x1014_6bc8, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
        l_0x1014_6bcc:
            ii(0x1014_6bcc, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1014_6bcf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_6bd1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_6bd2, 1); pop(edi);                               /* pop edi */
            ii(0x1014_6bd3, 1); pop(esi);                               /* pop esi */
            ii(0x1014_6bd4, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_6bd5, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_6bd6, 1); ret();                                  /* ret */
        }
    }
}
