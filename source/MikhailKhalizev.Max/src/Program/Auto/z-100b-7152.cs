using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7152-2631a55f")]
        public void Method_100b_7152()
        {
            ii(0x100b_7152, 5); push(0x28);                             /* push 0x28 */
            ii(0x100b_7157, 5); call(Definitions.sys_check_available_stack_size, 0xa_ebf6); /* call 0x10165d52 */
            ii(0x100b_715c, 1); push(ebx);                              /* push ebx */
            ii(0x100b_715d, 1); push(ecx);                              /* push ecx */
            ii(0x100b_715e, 1); push(edx);                              /* push edx */
            ii(0x100b_715f, 1); push(esi);                              /* push esi */
            ii(0x100b_7160, 1); push(edi);                              /* push edi */
            ii(0x100b_7161, 1); push(ebp);                              /* push ebp */
            ii(0x100b_7162, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7164, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_716a, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100b_716d, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100b_7171, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100b_7174, 7); mov(ax, memw[ds, eax + 0x101c_81c0]);   /* mov ax, [eax+0x101c81c0] */
            ii(0x100b_717b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_717e, 6); test(memw[ss, ebp - 8], 0x200);         /* test word [ebp-0x8], 0x200 */
            ii(0x100b_7184, 2); if(jz(0x100b_71ac, 0x26)) goto l_0x100b_71ac; /* jz 0x100b71ac */
            ii(0x100b_7186, 6); test(memw[ss, ebp - 8], 1);             /* test word [ebp-0x8], 0x1 */
            ii(0x100b_718c, 2); if(jz(0x100b_719d, 0xf)) goto l_0x100b_719d; /* jz 0x100b719d */
            ii(0x100b_718e, 5); mov(eax, 0x101c_8178);                  /* mov eax, 0x101c8178 */
            ii(0x100b_7193, 5); call(0x1007_6338, -0x4_0e60);           /* call 0x10076338 */
            ii(0x100b_7198, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_719b, 2); jmp(0x100b_71d0, 0x33); goto l_0x100b_71d0; /* jmp 0x100b71d0 */
        l_0x100b_719d:
            ii(0x100b_719d, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100b_71a2, 5); call(0x1007_6338, -0x4_0e6f);           /* call 0x10076338 */
            ii(0x100b_71a7, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_71aa, 2); jmp(0x100b_71d0, 0x24); goto l_0x100b_71d0; /* jmp 0x100b71d0 */
        l_0x100b_71ac:
            ii(0x100b_71ac, 6); test(memw[ss, ebp - 8], 0x40);          /* test word [ebp-0x8], 0x40 */
            ii(0x100b_71b2, 2); if(jz(0x100b_71c3, 0xf)) goto l_0x100b_71c3; /* jz 0x100b71c3 */
            ii(0x100b_71b4, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x100b_71b9, 5); call(0x1007_6338, -0x4_0e86);           /* call 0x10076338 */
            ii(0x100b_71be, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_71c1, 2); jmp(0x100b_71d0, 0xd); goto l_0x100b_71d0; /* jmp 0x100b71d0 */
        l_0x100b_71c3:
            ii(0x100b_71c3, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100b_71c8, 5); call(0x1007_6338, -0x4_0e95);           /* call 0x10076338 */
            ii(0x100b_71cd, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
        l_0x100b_71d0:
            ii(0x100b_71d0, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_71d3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_71d5, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_71d6, 1); pop(edi);                               /* pop edi */
            ii(0x100b_71d7, 1); pop(esi);                               /* pop esi */
            ii(0x100b_71d8, 1); pop(edx);                               /* pop edx */
            ii(0x100b_71d9, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_71da, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_71db, 1); ret();                                  /* ret */
        }
    }
}
