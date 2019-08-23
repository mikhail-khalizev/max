using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_3b89-32fcf766")]
        public void Method_1011_3b89()
        {
            ii(0x1011_3b89, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1011_3b8e, 5); call(Definitions.sys_check_available_stack_size, 0x5_21bf); /* call 0x10165d52 */
            ii(0x1011_3b93, 1); push(ebx);                              /* push ebx */
            ii(0x1011_3b94, 1); push(ecx);                              /* push ecx */
            ii(0x1011_3b95, 1); push(edx);                              /* push edx */
            ii(0x1011_3b96, 1); push(esi);                              /* push esi */
            ii(0x1011_3b97, 1); push(edi);                              /* push edi */
            ii(0x1011_3b98, 1); push(ebp);                              /* push ebp */
            ii(0x1011_3b99, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_3b9b, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1011_3ba1, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_3ba4, 7); mov(memd[ss, ebp - 0x8], 0x18);         /* mov dword [ebp-0x8], 0x18 */
        l_0x1011_3bab:
            ii(0x1011_3bab, 3); dec(memd[ss, ebp - 0x8]);               /* dec dword [ebp-0x8] */
            ii(0x1011_3bae, 5); cmp(memw[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x1011_3bb3, 2); if(jz(0x1011_3c09, 0x54)) goto l_0x1011_3c09; /* jz 0x10113c09 */
            ii(0x1011_3bb5, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_3bb9, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_3bbc, 3); add(eax, memd[ss, ebp - 0x4]);          /* add eax, [ebp-0x4] */
            ii(0x1011_3bbf, 4); cmp(memd[ds, eax + 0x16], 0);           /* cmp dword [eax+0x16], 0x0 */
            ii(0x1011_3bc3, 2); if(jz(0x1011_3c07, 0x42)) goto l_0x1011_3c07; /* jz 0x10113c07 */
            ii(0x1011_3bc5, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_3bc9, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_3bcc, 3); add(eax, memd[ss, ebp - 0x4]);          /* add eax, [ebp-0x4] */
            ii(0x1011_3bcf, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x1011_3bd2, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1011_3bd5, 4); cmp(memd[ss, ebp - 0xc], 0);            /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1011_3bd9, 2); if(jz(0x1011_3bef, 0x14)) goto l_0x1011_3bef; /* jz 0x10113bef */
            ii(0x1011_3bdb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_3bdd, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_3be0, 5); call(Definitions.my_dtor_d2, -0x4_56ad); /* call 0x100ce538 */
            ii(0x1011_3be5, 5); call(Definitions.sys_delete, 0x5_237a); /* call 0x10165f64 */
            ii(0x1011_3bea, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_3bed, 2); jmp(0x1011_3bf6, 0x7); goto l_0x1011_3bf6; /* jmp 0x10113bf6 */
        l_0x1011_3bef:
            ii(0x1011_3bef, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x1011_3bf6:
            ii(0x1011_3bf6, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_3bfa, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_3bfd, 3); add(eax, memd[ss, ebp - 0x4]);          /* add eax, [ebp-0x4] */
            ii(0x1011_3c00, 7); mov(memd[ds, eax + 0x16], 0);           /* mov dword [eax+0x16], 0x0 */
        l_0x1011_3c07:
            ii(0x1011_3c07, 2); jmp(0x1011_3bab, -0x5e); goto l_0x1011_3bab; /* jmp 0x10113bab */
        l_0x1011_3c09:
            ii(0x1011_3c09, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_3c0b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_3c0c, 1); pop(edi);                               /* pop edi */
            ii(0x1011_3c0d, 1); pop(esi);                               /* pop esi */
            ii(0x1011_3c0e, 1); pop(edx);                               /* pop edx */
            ii(0x1011_3c0f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_3c10, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_3c11, 1); ret();                                  /* ret */
        }
    }
}
