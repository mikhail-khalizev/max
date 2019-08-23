using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_92fe-494f01")]
        public void Method_100f_92fe()
        {
            ii(0x100f_92fe, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100f_9303, 5); calld(Definitions.sys_check_available_stack_size, 0x6_ca4a); /* call 0x10165d52 */
            ii(0x100f_9308, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_9309, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_930a, 1); pushd(edx);                             /* push edx */
            ii(0x100f_930b, 1); pushd(esi);                             /* push esi */
            ii(0x100f_930c, 1); pushd(edi);                             /* push edi */
            ii(0x100f_930d, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_930e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_9310, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100f_9316, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_9319, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_931b, 5); calld(0x100f_448c, -0x4e94);            /* call 0x100f448c */
            ii(0x100f_9320, 5); calld(0x100f_f5c1, 0x629c);             /* call 0x100ff5c1 */
            ii(0x100f_9325, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_9328, 5); calld(0x100f_f637, 0x630a);             /* call 0x100ff637 */
            ii(0x100f_932d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_9330, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_9332, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100f_9335, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9337, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100f_933c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_933e, 2); if(jnzd(0x100f_935d, 0x1d)) goto l_0x100f_935d; /* jnz 0x100f935d */
            ii(0x100f_9340, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9342, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100f_9347, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_934d, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_9353, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_9358, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_935b, 2); if(jzd(0x100f_935f, 0x2)) goto l_0x100f_935f; /* jz 0x100f935f */
        l_0x100f_935d:
            ii(0x100f_935d, 2); jmpd(0x100f_9395, 0x36); goto l_0x100f_9395; /* jmp 0x100f9395 */
        l_0x100f_935f:
            ii(0x100f_935f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_9362, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x100f_9366, 2); if(jzd(0x100f_9385, 0x1d)) goto l_0x100f_9385; /* jz 0x100f9385 */
            ii(0x100f_9368, 7); cmp(memb_a32[ds, 0x101c_391e], 0x9);    /* cmp byte [0x101c391e], 0x9 */
            ii(0x100f_936f, 2); if(jnzd(0x100f_937d, 0xc)) goto l_0x100f_937d; /* jnz 0x100f937d */
            ii(0x100f_9371, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9373, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100f_9378, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_937b, 2); if(jnzd(0x100f_9385, 0x8)) goto l_0x100f_9385; /* jnz 0x100f9385 */
        l_0x100f_937d:
            ii(0x100f_937d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_9380, 5); calld(0x100f_40f6, -0x528f);            /* call 0x100f40f6 */
        l_0x100f_9385:
            ii(0x100f_9385, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_9388, 5); calld(0x100f_28a2, -0x6aeb);            /* call 0x100f28a2 */
            ii(0x100f_938d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_9390, 5); calld(0x100f_246b, -0x6f2a);            /* call 0x100f246b */
        l_0x100f_9395:
            ii(0x100f_9395, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_9397, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_9398, 1); popd(edi);                              /* pop edi */
            ii(0x100f_9399, 1); popd(esi);                              /* pop esi */
            ii(0x100f_939a, 1); popd(edx);                              /* pop edx */
            ii(0x100f_939b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_939c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_939d, 1); retd();                                 /* ret */
        }
    }
}
