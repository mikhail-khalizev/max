using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_28ff-9c5959db")]
        public void Method_100a_28ff()
        {
            ii(0x100a_28ff, 5); push(0x34);                             /* push 0x34 */
            ii(0x100a_2904, 5); call(Definitions.sys_check_available_stack_size, 0xc_3449); /* call 0x10165d52 */
            ii(0x100a_2909, 1); push(ebx);                              /* push ebx */
            ii(0x100a_290a, 1); push(ecx);                              /* push ecx */
            ii(0x100a_290b, 1); push(esi);                              /* push esi */
            ii(0x100a_290c, 1); push(edi);                              /* push edi */
            ii(0x100a_290d, 1); push(ebp);                              /* push ebp */
            ii(0x100a_290e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_2910, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100a_2916, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_2919, 3); mov(memb[ss, ebp - 4], dl);             /* mov [ebp-0x4], dl */
            ii(0x100a_291c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_291f, 5); call(0x1008_ad28, -0x1_7bfc);           /* call 0x1008ad28 */
            ii(0x100a_2924, 2); test(al, al);                           /* test al, al */
            ii(0x100a_2926, 2); if(jnz(0x100a_2975, 0x4d)) goto l_0x100a_2975; /* jnz 0x100a2975 */
            ii(0x100a_2928, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_292a, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x100a_292d, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100a_2930, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x100a_2935, 5); call(Definitions.sys_new, 0xc_34c6);    /* call 0x10165e00 */
            ii(0x100a_293a, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100a_293d, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100a_2940, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100a_2943, 4); cmp(memd[ss, ebp - 20], 0);             /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100a_2947, 2); if(jz(0x100a_295f, 0x16)) goto l_0x100a_295f; /* jz 0x100a295f */
            ii(0x100a_2949, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100a_294c, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100a_294f, 5); call(Definitions.my_ctor_c11, 0xf75);   /* call 0x100a38c9 */
            ii(0x100a_2954, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x100a_2957, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100a_295a, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x100a_295d, 2); jmp(0x100a_2965, 6); goto l_0x100a_2965; /* jmp 0x100a2965 */
        l_0x100a_295f:
            ii(0x100a_295f, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100a_2962, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
        l_0x100a_2965:
            ii(0x100a_2965, 3); mov(edx, memd[ss, ebp - 28]);           /* mov edx, [ebp-0x1c] */
            ii(0x100a_2968, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_296d, 3); mov(ebx, memd[ss, ebp - 12]);           /* mov ebx, [ebp-0xc] */
            ii(0x100a_2970, 5); call(0x100a_4db6, 0x2441);              /* call 0x100a4db6 */
        l_0x100a_2975:
            ii(0x100a_2975, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_2977, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_2978, 1); pop(edi);                               /* pop edi */
            ii(0x100a_2979, 1); pop(esi);                               /* pop esi */
            ii(0x100a_297a, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_297b, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_297c, 1); ret();                                  /* ret */
        }
    }
}
