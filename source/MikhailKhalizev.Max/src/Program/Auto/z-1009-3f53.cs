using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_3f53-38c5fc95")]
        public void Method_1009_3f53()
        {
            ii(0x1009_3f53, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1009_3f58, 5); call(Definitions.sys_check_available_stack_size, 0xd_1df5); /* call 0x10165d52 */
            ii(0x1009_3f5d, 1); push(ebx);                              /* push ebx */
            ii(0x1009_3f5e, 1); push(ecx);                              /* push ecx */
            ii(0x1009_3f5f, 1); push(edx);                              /* push edx */
            ii(0x1009_3f60, 1); push(esi);                              /* push esi */
            ii(0x1009_3f61, 1); push(edi);                              /* push edi */
            ii(0x1009_3f62, 1); push(ebp);                              /* push ebp */
            ii(0x1009_3f63, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_3f65, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1009_3f6b, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1009_3f6e, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1009_3f72, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1009_3f78, 7); mov(ax, memw[ds, eax + 0x101c_a550]);   /* mov ax, [eax+0x101ca550] */
            ii(0x1009_3f7f, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_3f82, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1009_3f86, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_3f88, 2); if(jnz(0x1009_3f90, 6)) goto l_0x1009_3f90; /* jnz 0x10093f90 */
            ii(0x1009_3f8a, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
            ii(0x1009_3f8e, 2); jmp(0x1009_3fe5, 0x55); goto l_0x1009_3fe5; /* jmp 0x10093fe5 */
        l_0x1009_3f90:
            ii(0x1009_3f90, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1009_3f97, 2); jmp(0x1009_3f9f, 6); goto l_0x1009_3f9f; /* jmp 0x10093f9f */
        l_0x1009_3f99:
            ii(0x1009_3f99, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_3f9c, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
        l_0x1009_3f9f:
            ii(0x1009_3f9f, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1009_3fa3, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x1009_3fa6, 2); if(jge(0x1009_3fe1, 0x39)) goto l_0x1009_3fe1; /* jge 0x10093fe1 */
            ii(0x1009_3fa8, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1009_3fac, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1009_3fb2, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1009_3fb8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_3fbd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_3fbf, 2); if(jz(0x1009_3fd7, 0x16)) goto l_0x1009_3fd7; /* jz 0x10093fd7 */
            ii(0x1009_3fc1, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1009_3fc5, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1009_3fcb, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1009_3fcf, 6); cmp(edx, memd[ds, eax + 0x101c_a550]);  /* cmp edx, [eax+0x101ca550] */
            ii(0x1009_3fd5, 2); if(jle(0x1009_3fd9, 2)) goto l_0x1009_3fd9; /* jle 0x10093fd9 */
        l_0x1009_3fd7:
            ii(0x1009_3fd7, 2); jmp(0x1009_3fdf, 6); goto l_0x1009_3fdf; /* jmp 0x10093fdf */
        l_0x1009_3fd9:
            ii(0x1009_3fd9, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
            ii(0x1009_3fdd, 2); jmp(0x1009_3fe5, 6); goto l_0x1009_3fe5; /* jmp 0x10093fe5 */
        l_0x1009_3fdf:
            ii(0x1009_3fdf, 2); jmp(0x1009_3f99, -0x48); goto l_0x1009_3f99; /* jmp 0x10093f99 */
        l_0x1009_3fe1:
            ii(0x1009_3fe1, 4); mov(memb[ss, ebp - 8], 1);              /* mov byte [ebp-0x8], 0x1 */
        l_0x1009_3fe5:
            ii(0x1009_3fe5, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1009_3fe8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_3fea, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_3feb, 1); pop(edi);                               /* pop edi */
            ii(0x1009_3fec, 1); pop(esi);                               /* pop esi */
            ii(0x1009_3fed, 1); pop(edx);                               /* pop edx */
            ii(0x1009_3fee, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_3fef, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_3ff0, 1); ret();                                  /* ret */
        }
    }
}
