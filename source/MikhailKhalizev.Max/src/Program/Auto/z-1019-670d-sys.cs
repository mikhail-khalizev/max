using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_670d-2132163a")]
        public void /* sys */ Method_1019_670d()
        {
            ii(0x1019_670d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_670e, 1); pushd(esi);                             /* push esi */
            ii(0x1019_670f, 1); pushd(edi);                             /* push edi */
            ii(0x1019_6710, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_6711, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1019_6714, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1019_6716, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1019_6718, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1019_671a, 2); mov(ebx, ds);                           /* mov ebx, ds */
            ii(0x1019_671c, 7); mov(memd_a32[ds, edi + 0xc], 0);        /* mov dword [edi+0xc], 0x0 */
            ii(0x1019_6723, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x1019_6725, 3); mov(dl, memb_a32[ds, edi + 0x15]);      /* mov dl, [edi+0x15] */
            ii(0x1019_6728, 2); xor(ebp, ebp);                          /* xor ebp, ebp */
            ii(0x1019_672a, 3); cmp(dl, 0x47);                          /* cmp dl, 0x47 */
            ii(0x1019_672d, 2); if(jbd(0x1019_674c, 0x1d)) goto l_0x1019_674c; /* jb 0x1019674c */
            ii(0x1019_672f, 2); if(jbed(0x1019_6759, 0x28)) goto l_0x1019_6759; /* jbe 0x10196759 */
            ii(0x1019_6731, 3); cmp(dl, 0x66);                          /* cmp dl, 0x66 */
            ii(0x1019_6734, 2); if(jbd(0x1019_6742, 0xc)) goto l_0x1019_6742; /* jb 0x10196742 */
            ii(0x1019_6736, 2); if(jbed(0x1019_676e, 0x36)) goto l_0x1019_676e; /* jbe 0x1019676e */
            ii(0x1019_6738, 3); cmp(dl, 0x67);                          /* cmp dl, 0x67 */
            ii(0x1019_673b, 2); if(jzd(0x1019_6759, 0x1c)) goto l_0x1019_6759; /* jz 0x10196759 */
            ii(0x1019_673d, 5); jmpd(0x1019_67eb, 0xa9); goto l_0x1019_67eb; /* jmp 0x101967eb */
        l_0x1019_6742:
            ii(0x1019_6742, 3); cmp(dl, 0x65);                          /* cmp dl, 0x65 */
            ii(0x1019_6745, 2); if(jzd(0x1019_6769, 0x22)) goto l_0x1019_6769; /* jz 0x10196769 */
            ii(0x1019_6747, 5); jmpd(0x1019_67eb, 0x9f); goto l_0x1019_67eb; /* jmp 0x101967eb */
        l_0x1019_674c:
            ii(0x1019_674c, 3); cmp(dl, 0x45);                          /* cmp dl, 0x45 */
            ii(0x1019_674f, 6); if(jbd(0x1019_67eb, 0x96)) goto l_0x1019_67eb; /* jb 0x101967eb */
            ii(0x1019_6755, 2); if(jbed(0x1019_6769, 0x12)) goto l_0x1019_6769; /* jbe 0x10196769 */
            ii(0x1019_6757, 2); jmpd(0x1019_676e, 0x15); goto l_0x1019_676e; /* jmp 0x1019676e */
        l_0x1019_6759:
            ii(0x1019_6759, 4); cmp(memd_a32[ds, edi + 0x8], 0);        /* cmp dword [edi+0x8], 0x0 */
            ii(0x1019_675d, 2); if(jnzd(0x1019_6766, 0x7)) goto l_0x1019_6766; /* jnz 0x10196766 */
            ii(0x1019_675f, 7); mov(memd_a32[ds, edi + 0x8], 0x1);      /* mov dword [edi+0x8], 0x1 */
        l_0x1019_6766:
            ii(0x1019_6766, 3); sub(dl, 0x2);                           /* sub dl, 0x2 */
        l_0x1019_6769:
            ii(0x1019_6769, 5); mov(ebp, 0x1);                          /* mov ebp, 0x1 */
        l_0x1019_676e:
            ii(0x1019_676e, 2); mov(ecx, memd_a32[ds, eax]);            /* mov ecx, [eax] */
            ii(0x1019_6770, 3); add(ecx, 0x8);                          /* add ecx, 0x8 */
            ii(0x1019_6773, 2); mov(memd_a32[ds, eax], ecx);            /* mov [eax], ecx */
            ii(0x1019_6775, 3); mov(eax, memd_a32[ds, ecx - 0x8]);      /* mov eax, [ecx-0x8] */
            ii(0x1019_6778, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1019_677b, 3); mov(eax, memd_a32[ds, ecx - 0x4]);      /* mov eax, [ecx-0x4] */
            ii(0x1019_677e, 4); mov(memd_a32[ss, esp + 0x4], eax);      /* mov [esp+0x4], eax */
            ii(0x1019_6782, 4); cmp(memd_a32[ds, edi + 0x8], -0x1 /* 0xff */); /* cmp dword [edi+0x8], 0xffffffff */
            ii(0x1019_6786, 2); if(jnzd(0x1019_678f, 0x7)) goto l_0x1019_678f; /* jnz 0x1019678f */
            ii(0x1019_6788, 7); mov(memd_a32[ds, edi + 0x8], 0x6);      /* mov dword [edi+0x8], 0x6 */
        l_0x1019_678f:
            ii(0x1019_678f, 3); mov(al, memb_a32[ds, edi + 0x15]);      /* mov al, [edi+0x15] */
            ii(0x1019_6792, 2); and(al, 0x5f);                          /* and al, 0x5f */
            ii(0x1019_6794, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1019_6799, 1); pushd(eax);                             /* push eax */
            ii(0x1019_679a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_679c, 2); mov(al, dl);                            /* mov al, dl */
            ii(0x1019_679e, 1); pushd(eax);                             /* push eax */
            ii(0x1019_679f, 2); pushd(0x3);                             /* push 0x3 */
            ii(0x1019_67a1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_67a2, 3); mov(ebx, memd_a32[ds, edi + 0x8]);      /* mov ebx, [edi+0x8] */
            ii(0x1019_67a5, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1019_67a7, 5); pushd(0xff);                            /* push 0xff */
            ii(0x1019_67ac, 4); lea(edx, esp + 0x14);                   /* lea edx, [esp+0x14] */
            ii(0x1019_67b0, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1019_67b2, 5); calld(/* sys */ 0x1019_b98f, 0x51d8);   /* call 0x1019b98f */
            ii(0x1019_67b7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_67b9, 2); mov(al, memb_a32[ds, esi]);             /* mov al, [esi] */
            ii(0x1019_67bb, 3); cmp(eax, 0x2a);                         /* cmp eax, 0x2a */
            ii(0x1019_67be, 2); if(jnzd(0x1019_67c4, 0x4)) goto l_0x1019_67c4; /* jnz 0x101967c4 */
            ii(0x1019_67c0, 4); mov(memb_a32[ds, edi + 0x16], 0x2a);    /* mov byte [edi+0x16], 0x2a */
        l_0x1019_67c4:
            ii(0x1019_67c4, 7); mov(memb_a32[ds, esi + 0xff], 0);       /* mov byte [esi+0xff], 0x0 */
        l_0x1019_67cb:
            ii(0x1019_67cb, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_67cd, 2); mov(al, memb_a32[ds, esi]);             /* mov al, [esi] */
            ii(0x1019_67cf, 3); cmp(eax, 0x20);                         /* cmp eax, 0x20 */
            ii(0x1019_67d2, 2); if(jnzd(0x1019_67d7, 0x3)) goto l_0x1019_67d7; /* jnz 0x101967d7 */
            ii(0x1019_67d4, 1); inc(esi);                               /* inc esi */
            ii(0x1019_67d5, 2); jmpd(0x1019_67cb, -0xc); goto l_0x1019_67cb; /* jmp 0x101967cb */
        l_0x1019_67d7:
            ii(0x1019_67d7, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1019_67d9, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1019_67db, 5); calld(/* sys */ 0x1019_67f7, 0x17);     /* call 0x101967f7 */
            ii(0x1019_67e0, 2); mov(ebx, ds);                           /* mov ebx, ds */
            ii(0x1019_67e2, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x1019_67e4, 7); mov(memd_a32[ds, edi + 0x8], 0xffff_ffff); /* mov dword [edi+0x8], 0xffffffff */
        l_0x1019_67eb:
            ii(0x1019_67eb, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1019_67ed, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1019_67ef, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1019_67f2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_67f3, 1); popd(edi);                              /* pop edi */
            ii(0x1019_67f4, 1); popd(esi);                              /* pop esi */
            ii(0x1019_67f5, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_67f6, 1); retd(); return;                         /* ret */
        }
    }
}
