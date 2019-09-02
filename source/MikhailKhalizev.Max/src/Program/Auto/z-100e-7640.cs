using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_7640-5c1a13f9")]
        public void Method_100e_7640()
        {
            ii(0x100e_7640, 5); push(0xc0);                             /* push 0xc0 */
            ii(0x100e_7645, 5); call(Definitions.sys_check_available_stack_size, 0x7_e708); /* call 0x10165d52 */
            ii(0x100e_764a, 1); push(ebx);                              /* push ebx */
            ii(0x100e_764b, 1); push(ecx);                              /* push ecx */
            ii(0x100e_764c, 1); push(edx);                              /* push edx */
            ii(0x100e_764d, 1); push(esi);                              /* push esi */
            ii(0x100e_764e, 1); push(edi);                              /* push edi */
            ii(0x100e_764f, 1); push(ebp);                              /* push ebp */
            ii(0x100e_7650, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_7652, 6); sub(esp, 0xa4);                         /* sub esp, 0xa4 */
            ii(0x100e_7658, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_765d, 5); call(Definitions.my_3_get_count, -0x5_c1e2); /* call 0x1008b480 */
            ii(0x100e_7662, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_7665, 4); or(memb[ss, ebp - 4], 1);               /* or byte [ebp-0x4], 0x1 */
            ii(0x100e_7669, 6); lea(eax, memd[ss, ebp - 0xa4]);         /* lea eax, [ebp-0xa4] */
            ii(0x100e_766f, 5); call(0x100e_82a0, 0xc2c);               /* call 0x100e82a0 */
            ii(0x100e_7674, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_7677, 4); and(memb[ss, ebp - 4], -2 /* 0xfe */);  /* and byte [ebp-0x4], 0xfe */
            ii(0x100e_767b, 5); mov(eax, 0x26);                         /* mov eax, 0x26 */
            ii(0x100e_7680, 5); call(0x100e_883d, 0x11b8);              /* call 0x100e883d */
            ii(0x100e_7685, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x100e_7688, 5); mov(memd[ds, 0x101c_9474], eax);        /* mov [0x101c9474], eax */
        l_0x100e_768d:
            ii(0x100e_768d, 3); dec(memd[ss, ebp - 8]);                 /* dec dword [ebp-0x8] */
            ii(0x100e_7690, 5); cmp(memw[ss, ebp - 8], -1 /* 0xff */);  /* cmp word [ebp-0x8], 0xffff */
            ii(0x100e_7695, 2); if(jz(0x100e_76b4, 0x1d)) goto l_0x100e_76b4; /* jz 0x100e76b4 */
            ii(0x100e_7697, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100e_769b, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_76a0, 5); call(0x100e_84b8, 0xe13);               /* call 0x100e84b8 */
            ii(0x100e_76a5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_76a7, 6); lea(eax, memd[ss, ebp - 0xa4]);         /* lea eax, [ebp-0xa4] */
            ii(0x100e_76ad, 5); call(0x100e_5484, -0x222e);             /* call 0x100e5484 */
            ii(0x100e_76b2, 2); jmp(0x100e_768d, -0x27); goto l_0x100e_768d; /* jmp 0x100e768d */
        l_0x100e_76b4:
            ii(0x100e_76b4, 7); cmp(memb[ds, 0x101c_391b], 0);          /* cmp byte [0x101c391b], 0x0 */
            ii(0x100e_76bb, 2); if(jz(0x100e_76c2, 5)) goto l_0x100e_76c2; /* jz 0x100e76c2 */
            ii(0x100e_76bd, 5); call(0x100e_7603, -0xbf);               /* call 0x100e7603 */
        l_0x100e_76c2:
            ii(0x100e_76c2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_76c4, 6); lea(eax, memd[ss, ebp - 0xa4]);         /* lea eax, [ebp-0xa4] */
            ii(0x100e_76ca, 5); call(0x100e_8184, 0xab5);               /* call 0x100e8184 */
            ii(0x100e_76cf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_76d1, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_76d2, 1); pop(edi);                               /* pop edi */
            ii(0x100e_76d3, 1); pop(esi);                               /* pop esi */
            ii(0x100e_76d4, 1); pop(edx);                               /* pop edx */
            ii(0x100e_76d5, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_76d6, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_76d7, 1); ret();                                  /* ret */
        }
    }
}
