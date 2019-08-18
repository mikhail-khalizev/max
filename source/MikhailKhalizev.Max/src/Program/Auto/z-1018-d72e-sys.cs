using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_d72e-5da1ae03")]
        public void /* sys */ Method_1018_d72e()
        {
            ii(0x1018_d72e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_d72f, 1); pushd(esi);                             /* push esi */
            ii(0x1018_d730, 1); pushd(edi);                             /* push edi */
            ii(0x1018_d731, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_d732, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1018_d735, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1018_d737, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1018_d739, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1018_d73b, 5); calld(/* sys */ 0x1019_46a5, 0x6f65);   /* call 0x101946a5 */
            ii(0x1018_d740, 2); test(al, 0x80);                         /* test al, 0x80 */
            ii(0x1018_d742, 2); if(jzd(0x1018_d773, 0x2f)) goto l_0x1018_d773; /* jz 0x1018d773 */
            ii(0x1018_d744, 2); mov(al, 0x2);                           /* mov al, 0x2 */
            ii(0x1018_d746, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x1018_d748, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_d74a, 2); mov(ah, 0x42);                          /* mov ah, 0x42 */
            ii(0x1018_d74c, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1018_d74e, 3); shr(ecx, 0x10);                         /* shr ecx, 0x10 */
            ii(0x1018_d751, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1018_d753, 3); rcl(dx, 0x1);                           /* rcl dx, 1 */
            ii(0x1018_d756, 3); ror(dx, 0x1);                           /* ror dx, 1 */
            ii(0x1018_d759, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1018_d75c, 3); mov(dx, ax);                            /* mov dx, ax */
            ii(0x1018_d75f, 3); mov(memd_a32[ss, esp], edx);            /* mov [esp], edx */
            ii(0x1018_d762, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1018_d764, 2); if(jged(0x1018_d773, 0xd)) goto l_0x1018_d773; /* jge 0x1018d773 */
        l_0x1018_d766:
            ii(0x1018_d766, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_d768, 4); mov(ax, memw_a32[ss, esp]);             /* mov ax, [esp] */
            ii(0x1018_d76c, 5); calld(/* sys */ 0x1018_dbb7, 0x446);    /* call 0x1018dbb7 */
            ii(0x1018_d771, 2); jmpd(0x1018_d79a, 0x27); goto l_0x1018_d79a; /* jmp 0x1018d79a */
        l_0x1018_d773:
            ii(0x1018_d773, 2); mov(ecx, edi);                          /* mov ecx, edi */
            ii(0x1018_d775, 2); mov(edx, ebp);                          /* mov edx, ebp */
            ii(0x1018_d777, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x1018_d779, 2); mov(ah, 0x40);                          /* mov ah, 0x40 */
            ii(0x1018_d77b, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1018_d77d, 2); rcl(eax, 0x1);                          /* rcl eax, 1 */
            ii(0x1018_d77f, 2); ror(eax, 0x1);                          /* ror eax, 1 */
            ii(0x1018_d781, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1018_d784, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_d786, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_d788, 2); if(jld(0x1018_d766, -0x24)) goto l_0x1018_d766; /* jl 0x1018d766 */
            ii(0x1018_d78a, 2); cmp(eax, edi);                          /* cmp eax, edi */
            ii(0x1018_d78c, 2); if(jzd(0x1018_d798, 0xa)) goto l_0x1018_d798; /* jz 0x1018d798 */
            ii(0x1018_d78e, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1018_d793, 5); calld(/* sys */ 0x1018_d3bf, -0x3d9);   /* call 0x1018d3bf */
        l_0x1018_d798:
            ii(0x1018_d798, 2); mov(eax, edx);                          /* mov eax, edx */
        l_0x1018_d79a:
            ii(0x1018_d79a, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1018_d79d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_d79e, 1); popd(edi);                              /* pop edi */
            ii(0x1018_d79f, 1); popd(esi);                              /* pop esi */
            ii(0x1018_d7a0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_d7a1, 1); retd(); return;                         /* ret */
        }
    }
}
