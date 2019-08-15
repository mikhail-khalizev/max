using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5594f844-c740-42fb-a63a-eb6623f0c380")]
        public void Method_1008_9464()
        {
            ii(0x1008_9464, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_9469, 5); calld(Definitions.sys_check_available_stack_size, 0xd_c8e4); /* call 0x10165d52 */
            ii(0x1008_946e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_946f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9470, 1); pushd(esi);                             /* push esi */
            ii(0x1008_9471, 1); pushd(edi);                             /* push edi */
            ii(0x1008_9472, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_9473, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9475, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_947b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_947e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_9481, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1008_9488, 2); if(jzd(0x1008_94a1, 0x17)) goto l_0x1008_94a1; /* jz 0x100894a1 */
            ii(0x1008_948a, 5); mov(edx, 0x101b_3a54);                  /* mov edx, 0x101b3a54 */
            ii(0x1008_948f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9492, 5); calld(Definitions.sys_call_dtor_arr, 0xd_cb21); /* call 0x10165fb8 */
            ii(0x1008_9497, 5); calld(Definitions.sys_delete_arr, 0xd_cb3c); /* call 0x10165fd8 */
            ii(0x1008_949c, 5); jmpd(0x1008_955a, 0xb9); goto l_0x1008_955a; /* jmp 0x1008955a */
        l_0x1008_94a1:
            ii(0x1008_94a1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_94a3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_94a6, 3); add(eax, 0x42);                         /* add eax, 0x42 */
            ii(0x1008_94a9, 5); calld(0x1008_8b04, -0x9aa);             /* call 0x10088b04 */
            ii(0x1008_94ae, 3); sub(eax, 0x42);                         /* sub eax, 0x42 */
            ii(0x1008_94b1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_94b4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_94b6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_94b9, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_94bc, 5); calld(0x1007_5f2c, -0x1_3595);          /* call 0x10075f2c */
            ii(0x1008_94c1, 3); sub(eax, 0x3e);                         /* sub eax, 0x3e */
            ii(0x1008_94c4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_94c7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_94c9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_94cc, 3); add(eax, 0x36);                         /* add eax, 0x36 */
            ii(0x1008_94cf, 5); calld(0x1008_8b7c, -0x958);             /* call 0x10088b7c */
            ii(0x1008_94d4, 3); sub(eax, 0x36);                         /* sub eax, 0x36 */
            ii(0x1008_94d7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_94da, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_94dc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_94df, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_94e2, 5); calld(0x1007_5f2c, -0x1_35bb);          /* call 0x10075f2c */
            ii(0x1008_94e7, 3); sub(eax, 0x32);                         /* sub eax, 0x32 */
            ii(0x1008_94ea, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_94ed, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_94ef, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_94f2, 3); add(eax, 0x2e);                         /* add eax, 0x2e */
            ii(0x1008_94f5, 5); calld(0x1008_9424, -0xd6);              /* call 0x10089424 */
            ii(0x1008_94fa, 3); sub(eax, 0x2e);                         /* sub eax, 0x2e */
            ii(0x1008_94fd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9500, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_9502, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9505, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_9508, 5); calld(0x1008_8fc4, -0x549);             /* call 0x10088fc4 */
            ii(0x1008_950d, 3); sub(eax, 0x2a);                         /* sub eax, 0x2a */
            ii(0x1008_9510, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9513, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_9515, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9518, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_951b, 5); calld(0x1008_9004, -0x51c);             /* call 0x10089004 */
            ii(0x1008_9520, 3); sub(eax, 0x20);                         /* sub eax, 0x20 */
            ii(0x1008_9523, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9526, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_9528, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_952b, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x1008_952e, 5); calld(0x1008_9004, -0x52f);             /* call 0x10089004 */
            ii(0x1008_9533, 3); sub(eax, 0x16);                         /* sub eax, 0x16 */
            ii(0x1008_9536, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9539, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_953e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9541, 5); calld(0x100a_284c, 0x1_9306);           /* call 0x100a284c */
            ii(0x1008_9546, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9549, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1008_9550, 2); if(jzd(0x1008_955a, 0x8)) goto l_0x1008_955a; /* jz 0x1008955a */
            ii(0x1008_9552, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9555, 5); calld(Definitions.sys_delete, 0xd_ca0a); /* call 0x10165f64 */
        l_0x1008_955a:
            ii(0x1008_955a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_955d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_9560, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_9563, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9565, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_9566, 1); popd(edi);                              /* pop edi */
            ii(0x1008_9567, 1); popd(esi);                              /* pop esi */
            ii(0x1008_9568, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_9569, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_956a, 1); retd(); return;                         /* ret */
        }
    }
}
