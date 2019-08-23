using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_a981-18a39983")]
        public void Method_1015_a981()
        {
            ii(0x1015_a981, 5); push(0x30);                             /* push 0x30 */
            ii(0x1015_a986, 5); call(Definitions.sys_check_available_stack_size, 0xb3c7); /* call 0x10165d52 */
            ii(0x1015_a98b, 1); push(ebx);                              /* push ebx */
            ii(0x1015_a98c, 1); push(ecx);                              /* push ecx */
            ii(0x1015_a98d, 1); push(esi);                              /* push esi */
            ii(0x1015_a98e, 1); push(edi);                              /* push edi */
            ii(0x1015_a98f, 1); push(ebp);                              /* push ebp */
            ii(0x1015_a990, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_a992, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1015_a998, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_a99b, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_a99e, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1015_a9a2, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_a9a5, 4); mov(ax, memw[ds, eax + 0x1c]);          /* mov ax, [eax+0x1c] */
            ii(0x1015_a9a9, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1015_a9ac, 2); jmp(0x1015_a9b4, 0x6); goto l_0x1015_a9b4; /* jmp 0x1015a9b4 */
        l_0x1015_a9ae:
            ii(0x1015_a9ae, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_a9b1, 3); dec(memd[ss, ebp - 0x10]);              /* dec dword [ebp-0x10] */
        l_0x1015_a9b4:
            ii(0x1015_a9b4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_a9b6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_a9b9, 3); mov(eax, memd[ds, eax + 0x1a]);         /* mov eax, [eax+0x1a] */
            ii(0x1015_a9bc, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_a9bf, 1); dec(eax);                               /* dec eax */
            ii(0x1015_a9c0, 5); call(0x1007_6e7c, -0xe_3b49);           /* call 0x10076e7c */
            ii(0x1015_a9c5, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1015_a9c9, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_a9cb, 2); if(jl(0x1015_a9d6, 0x9)) goto l_0x1015_a9d6; /* jl 0x1015a9d6 */
            ii(0x1015_a9cd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_a9cf, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1015_a9d2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_a9d4, 2); if(jz(0x1015_a9db, 0x5)) goto l_0x1015_a9db; /* jz 0x1015a9db */
        l_0x1015_a9d6:
            ii(0x1015_a9d6, 5); jmp(0x1015_aa5f, 0x84); goto l_0x1015_aa5f; /* jmp 0x1015aa5f */
        l_0x1015_a9db:
            ii(0x1015_a9db, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_a9de, 4); mov(ax, memw[ds, eax + 0x1a]);          /* mov ax, [eax+0x1a] */
            ii(0x1015_a9e2, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1015_a9e5, 2); jmp(0x1015_a9ed, 0x6); goto l_0x1015_a9ed; /* jmp 0x1015a9ed */
        l_0x1015_a9e7:
            ii(0x1015_a9e7, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_a9ea, 3); dec(memd[ss, ebp - 0x14]);              /* dec dword [ebp-0x14] */
        l_0x1015_a9ed:
            ii(0x1015_a9ed, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_a9ef, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_a9f2, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x1015_a9f5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_a9f8, 1); dec(eax);                               /* dec eax */
            ii(0x1015_a9f9, 5); call(0x1007_6e7c, -0xe_3b82);           /* call 0x10076e7c */
            ii(0x1015_a9fe, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1015_aa02, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_aa04, 2); if(jl(0x1015_aa0f, 0x9)) goto l_0x1015_aa0f; /* jl 0x1015aa0f */
            ii(0x1015_aa06, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_aa08, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1015_aa0b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_aa0d, 2); if(jz(0x1015_aa11, 0x2)) goto l_0x1015_aa11; /* jz 0x1015aa11 */
        l_0x1015_aa0f:
            ii(0x1015_aa0f, 2); jmp(0x1015_aa5a, 0x49); goto l_0x1015_aa5a; /* jmp 0x1015aa5a */
        l_0x1015_aa11:
            ii(0x1015_aa11, 4); movsx(ebx, memw[ss, ebp - 0x10]);       /* movsx ebx, word [ebp-0x10] */
            ii(0x1015_aa15, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1015_aa19, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_aa1c, 5); call(0x1015_a86b, -0x1b6);              /* call 0x1015a86b */
            ii(0x1015_aa21, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x1015_aa24, 4); cmp(memb[ss, ebp - 0xc], 0);            /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1015_aa28, 2); if(jz(0x1015_aa58, 0x2e)) goto l_0x1015_aa58; /* jz 0x1015aa58 */
            ii(0x1015_aa2a, 5); mov(eax, 0x1015_a76f);                  /* mov eax, 0x1015a76f */
            ii(0x1015_aa2f, 1); push(eax);                              /* push eax */
            ii(0x1015_aa30, 5); mov(ecx, 0x31);                         /* mov ecx, 0x31 */
            ii(0x1015_aa35, 5); mov(ebx, StringDefinitions.Start9);     /* mov ebx, 0x101b2759 */
            ii(0x1015_aa3a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_aa3c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_aa3f, 5); call(0x1015_7ccf, -0x2d75);             /* call 0x10157ccf */
            ii(0x1015_aa44, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_aa47, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1015_aa4a, 4); mov(memw[ds, edx + 0x41], ax);          /* mov [edx+0x41], ax */
            ii(0x1015_aa4e, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_aa51, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1015_aa54, 4); mov(memw[ds, edx + 0x43], ax);          /* mov [edx+0x43], ax */
        l_0x1015_aa58:
            ii(0x1015_aa58, 2); jmp(0x1015_a9e7, -0x73); goto l_0x1015_a9e7; /* jmp 0x1015a9e7 */
        l_0x1015_aa5a:
            ii(0x1015_aa5a, 5); jmp(0x1015_a9ae, -0xb1); goto l_0x1015_a9ae; /* jmp 0x1015a9ae */
        l_0x1015_aa5f:
            ii(0x1015_aa5f, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_aa62, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_aa65, 5); call(0x1015_8bbb, -0x1eaf);             /* call 0x10158bbb */
            ii(0x1015_aa6a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_aa6c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_aa6d, 1); pop(edi);                               /* pop edi */
            ii(0x1015_aa6e, 1); pop(esi);                               /* pop esi */
            ii(0x1015_aa6f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_aa70, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_aa71, 1); ret();                                  /* ret */
        }
    }
}
