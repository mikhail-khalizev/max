using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_7004-2ce96809")]
        public void /* sys */ Method_1017_7004()
        {
            ii(0x1017_7004, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_7005, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_7006, 1); pushd(edx);                             /* push edx */
            ii(0x1017_7007, 1); pushd(esi);                             /* push esi */
            ii(0x1017_7008, 1); pushd(edi);                             /* push edi */
            ii(0x1017_7009, 6); mov(edx, memd_a32[ds, 0x1020_9540]);    /* mov edx, [0x10209540] */
            ii(0x1017_700f, 5); calld(/* sys */ 0x1017_49cc, -0x2648);  /* call 0x101749cc */
            ii(0x1017_7014, 5); mov(ebx, 0xb2);                         /* mov ebx, 0xb2 */
            ii(0x1017_7019, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1017_701e, 5); mov(edi, 0x98);                         /* mov edi, 0x98 */
            ii(0x1017_7023, 6); mov(edx, memd_a32[ds, 0x1020_9540]);    /* mov edx, [0x10209540] */
            ii(0x1017_7029, 7); mov(memw_a32[ds, 0x1020_8bda], bx);     /* mov [0x10208bda], bx */
            ii(0x1017_7030, 7); mov(memw_a32[ds, 0x1020_8bdc], cx);     /* mov [0x10208bdc], cx */
            ii(0x1017_7037, 2); mov(esi, ecx);                          /* mov esi, ecx */
            ii(0x1017_7039, 7); mov(memw_a32[ds, 0x1020_8bde], cx);     /* mov [0x10208bde], cx */
            ii(0x1017_7040, 7); mov(memw_a32[ds, 0x1020_8be0], cx);     /* mov [0x10208be0], cx */
            ii(0x1017_7047, 7); mov(memw_a32[ds, 0x1020_8be2], cx);     /* mov [0x10208be2], cx */
            ii(0x1017_704e, 7); mov(memw_a32[ds, 0x1020_8a64], di);     /* mov [0x10208a64], di */
            ii(0x1017_7055, 5); mov(ebx, 0x26);                         /* mov ebx, 0x26 */
            ii(0x1017_705a, 5); mov(ecx, 0x31);                         /* mov ecx, 0x31 */
            ii(0x1017_705f, 5); mov(edi, 0x23);                         /* mov edi, 0x23 */
            ii(0x1017_7064, 7); mov(memw_a32[ds, 0x1020_8a58], si);     /* mov [0x10208a58], si */
            ii(0x1017_706b, 7); mov(memw_a32[ds, 0x1020_8a5a], si);     /* mov [0x10208a5a], si */
            ii(0x1017_7072, 7); mov(memw_a32[ds, 0x1020_8a5c], si);     /* mov [0x10208a5c], si */
            ii(0x1017_7079, 7); mov(memw_a32[ds, 0x1020_8a62], si);     /* mov [0x10208a62], si */
            ii(0x1017_7080, 7); mov(memw_a32[ds, 0x1020_8a66], si);     /* mov [0x10208a66], si */
            ii(0x1017_7087, 7); mov(memw_a32[ds, 0x1020_8a6c], si);     /* mov [0x10208a6c], si */
            ii(0x1017_708e, 7); mov(memw_a32[ds, 0x1020_8a70], si);     /* mov [0x10208a70], si */
            ii(0x1017_7095, 7); mov(memw_a32[ds, 0x1020_8a76], si);     /* mov [0x10208a76], si */
            ii(0x1017_709c, 7); mov(memw_a32[ds, 0x1020_8a7a], si);     /* mov [0x10208a7a], si */
            ii(0x1017_70a3, 7); mov(memw_a32[ds, 0x1020_8a80], si);     /* mov [0x10208a80], si */
            ii(0x1017_70aa, 7); mov(memw_a32[ds, 0x1020_8a84], si);     /* mov [0x10208a84], si */
            ii(0x1017_70b1, 7); mov(memw_a32[ds, 0x1020_8a8a], si);     /* mov [0x10208a8a], si */
            ii(0x1017_70b8, 7); mov(memw_a32[ds, 0x1020_8a8e], si);     /* mov [0x10208a8e], si */
            ii(0x1017_70bf, 7); mov(memw_a32[ds, 0x1020_8a94], si);     /* mov [0x10208a94], si */
            ii(0x1017_70c6, 7); mov(memw_a32[ds, 0x1020_8a98], si);     /* mov [0x10208a98], si */
            ii(0x1017_70cd, 7); mov(memw_a32[ds, 0x1020_8a9e], si);     /* mov [0x10208a9e], si */
            ii(0x1017_70d4, 7); mov(memw_a32[ds, 0x1020_8aa2], si);     /* mov [0x10208aa2], si */
            ii(0x1017_70db, 7); mov(memw_a32[ds, 0x1020_8aa8], si);     /* mov [0x10208aa8], si */
            ii(0x1017_70e2, 7); mov(memw_a32[ds, 0x1020_8aac], si);     /* mov [0x10208aac], si */
            ii(0x1017_70e9, 7); mov(memw_a32[ds, 0x1020_8ab2], si);     /* mov [0x10208ab2], si */
            ii(0x1017_70f0, 7); mov(memw_a32[ds, 0x1020_8ab6], si);     /* mov [0x10208ab6], si */
            ii(0x1017_70f7, 7); mov(memw_a32[ds, 0x1020_8abc], si);     /* mov [0x10208abc], si */
            ii(0x1017_70fe, 7); mov(memw_a32[ds, 0x1020_8ac0], si);     /* mov [0x10208ac0], si */
            ii(0x1017_7105, 7); mov(memw_a32[ds, 0x1020_8a54], bx);     /* mov [0x10208a54], bx */
            ii(0x1017_710c, 7); mov(memw_a32[ds, 0x1020_8a56], cx);     /* mov [0x10208a56], cx */
            ii(0x1017_7113, 7); mov(memw_a32[ds, 0x1020_8a6e], di);     /* mov [0x10208a6e], di */
            ii(0x1017_711a, 5); mov(ebx, 0xe9);                         /* mov ebx, 0xe9 */
            ii(0x1017_711f, 5); mov(ecx, 0x32);                         /* mov ecx, 0x32 */
            ii(0x1017_7124, 5); mov(edi, 0x7b);                         /* mov edi, 0x7b */
            ii(0x1017_7129, 7); mov(memw_a32[ds, 0x1020_8a5e], bx);     /* mov [0x10208a5e], bx */
            ii(0x1017_7130, 7); mov(memw_a32[ds, 0x1020_8a60], cx);     /* mov [0x10208a60], cx */
            ii(0x1017_7137, 7); mov(memw_a32[ds, 0x1020_8a78], di);     /* mov [0x10208a78], di */
            ii(0x1017_713e, 5); mov(ebx, 0x22);                         /* mov ebx, 0x22 */
            ii(0x1017_7143, 5); mov(ecx, 0x33);                         /* mov ecx, 0x33 */
            ii(0x1017_7148, 5); mov(edi, 0x5b);                         /* mov edi, 0x5b */
            ii(0x1017_714d, 7); mov(memw_a32[ds, 0x1020_8a68], bx);     /* mov [0x10208a68], bx */
            ii(0x1017_7154, 7); mov(memw_a32[ds, 0x1020_8a6a], cx);     /* mov [0x10208a6a], cx */
            ii(0x1017_715b, 7); mov(memw_a32[ds, 0x1020_8a82], di);     /* mov [0x10208a82], di */
            ii(0x1017_7162, 5); mov(ebx, 0x27);                         /* mov ebx, 0x27 */
            ii(0x1017_7167, 5); mov(ecx, 0x34);                         /* mov ecx, 0x34 */
            ii(0x1017_716c, 5); mov(edi, 0xa6);                         /* mov edi, 0xa6 */
            ii(0x1017_7171, 7); mov(memw_a32[ds, 0x1020_8a72], bx);     /* mov [0x10208a72], bx */
            ii(0x1017_7178, 7); mov(memw_a32[ds, 0x1020_8a74], cx);     /* mov [0x10208a74], cx */
            ii(0x1017_717f, 7); mov(memw_a32[ds, 0x1020_8a8c], di);     /* mov [0x10208a8c], di */
            ii(0x1017_7186, 5); mov(ebx, 0x28);                         /* mov ebx, 0x28 */
            ii(0x1017_718b, 5); mov(ecx, 0x35);                         /* mov ecx, 0x35 */
            ii(0x1017_7190, 5); mov(edi, 0x60);                         /* mov edi, 0x60 */
            ii(0x1017_7195, 7); mov(memw_a32[ds, 0x1020_8a7c], bx);     /* mov [0x10208a7c], bx */
            ii(0x1017_719c, 7); mov(memw_a32[ds, 0x1020_8a7e], cx);     /* mov [0x10208a7e], cx */
            ii(0x1017_71a3, 7); mov(memw_a32[ds, 0x1020_8a96], di);     /* mov [0x10208a96], di */
            ii(0x1017_71aa, 5); mov(ebx, 0x96);                         /* mov ebx, 0x96 */
            ii(0x1017_71af, 5); mov(ecx, 0x36);                         /* mov ecx, 0x36 */
            ii(0x1017_71b4, 5); mov(edi, 0x5c);                         /* mov edi, 0x5c */
            ii(0x1017_71b9, 7); mov(memw_a32[ds, 0x1020_8a86], bx);     /* mov [0x10208a86], bx */
            ii(0x1017_71c0, 7); mov(memw_a32[ds, 0x1020_8a88], cx);     /* mov [0x10208a88], cx */
            ii(0x1017_71c7, 7); mov(memw_a32[ds, 0x1020_8aa0], di);     /* mov [0x10208aa0], di */
            ii(0x1017_71ce, 5); mov(ebx, 0xe8);                         /* mov ebx, 0xe8 */
            ii(0x1017_71d3, 5); mov(ecx, 0x37);                         /* mov ecx, 0x37 */
            ii(0x1017_71d8, 5); mov(edi, 0x88);                         /* mov edi, 0x88 */
            ii(0x1017_71dd, 7); mov(memw_a32[ds, 0x1020_8a90], bx);     /* mov [0x10208a90], bx */
            ii(0x1017_71e4, 7); mov(memw_a32[ds, 0x1020_8a92], cx);     /* mov [0x10208a92], cx */
            ii(0x1017_71eb, 7); mov(memw_a32[ds, 0x1020_8aaa], di);     /* mov [0x10208aaa], di */
            ii(0x1017_71f2, 5); mov(ebx, 0x5f);                         /* mov ebx, 0x5f */
            ii(0x1017_71f7, 5); mov(ecx, 0x38);                         /* mov ecx, 0x38 */
            ii(0x1017_71fc, 5); mov(edi, 0x40);                         /* mov edi, 0x40 */
            ii(0x1017_7201, 7); mov(memw_a32[ds, 0x1020_8a9a], bx);     /* mov [0x10208a9a], bx */
            ii(0x1017_7208, 7); mov(memw_a32[ds, 0x1020_8a9c], cx);     /* mov [0x10208a9c], cx */
            ii(0x1017_720f, 7); mov(memw_a32[ds, 0x1020_8ab4], di);     /* mov [0x10208ab4], di */
            ii(0x1017_7216, 5); mov(ebx, 0xe7);                         /* mov ebx, 0xe7 */
            ii(0x1017_721b, 5); mov(ecx, 0x39);                         /* mov ecx, 0x39 */
            ii(0x1017_7220, 5); mov(edi, 0x5d);                         /* mov edi, 0x5d */
            ii(0x1017_7225, 7); mov(memw_a32[ds, 0x1020_8aa4], bx);     /* mov [0x10208aa4], bx */
            ii(0x1017_722c, 7); mov(memw_a32[ds, 0x1020_8aa6], cx);     /* mov [0x10208aa6], cx */
            ii(0x1017_7233, 7); mov(memw_a32[ds, 0x1020_8abe], di);     /* mov [0x10208abe], di */
            ii(0x1017_723a, 5); mov(ebx, 0xe0);                         /* mov ebx, 0xe0 */
            ii(0x1017_723f, 5); mov(ecx, 0x30);                         /* mov ecx, 0x30 */
            ii(0x1017_7244, 7); mov(memw_a32[ds, 0x1020_8aae], bx);     /* mov [0x10208aae], bx */
            ii(0x1017_724b, 7); mov(memw_a32[ds, 0x1020_8ab0], cx);     /* mov [0x10208ab0], cx */
            ii(0x1017_7252, 5); mov(ebx, 0x29);                         /* mov ebx, 0x29 */
            ii(0x1017_7257, 5); mov(ecx, 0xb0);                         /* mov ecx, 0xb0 */
            ii(0x1017_725c, 7); mov(memw_a32[ds, 0x1020_8ab8], bx);     /* mov [0x10208ab8], bx */
            ii(0x1017_7263, 7); mov(memw_a32[ds, 0x1020_8aba], cx);     /* mov [0x10208aba], cx */
            ii(0x1017_726a, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_726c, 2); if(jnzd(0x1017_7275, 0x7)) goto l_0x1017_7275; /* jnz 0x10177275 */
            ii(0x1017_726e, 5); mov(ebx, 0xd);                          /* mov ebx, 0xd */
            ii(0x1017_7273, 2); jmpd(0x1017_7290, 0x1b); goto l_0x1017_7290; /* jmp 0x10177290 */
        l_0x1017_7275:
            ii(0x1017_7275, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_7278, 2); if(jnzd(0x1017_7281, 0x7)) goto l_0x1017_7281; /* jnz 0x10177281 */
            ii(0x1017_727a, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1017_727f, 2); jmpd(0x1017_728e, 0xd); goto l_0x1017_728e; /* jmp 0x1017728e */
        l_0x1017_7281:
            ii(0x1017_7281, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_7284, 2); if(jzd(0x1017_7289, 0x3)) goto l_0x1017_7289; /* jz 0x10177289 */
            ii(0x1017_7286, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_7289:
            ii(0x1017_7289, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
        l_0x1017_728e:
            ii(0x1017_728e, 2); mov(ebx, eax);                          /* mov ebx, eax */
        l_0x1017_7290:
            ii(0x1017_7290, 7); lea(eax, ebx * 4 + 0);                  /* lea eax, [ebx*4] */
            ii(0x1017_7297, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_7299, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a40], 0x3d); /* mov word [eax*2+0x10208a40], 0x3d */
            ii(0x1017_72a3, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_72a5, 2); if(jnzd(0x1017_72ae, 0x7)) goto l_0x1017_72ae; /* jnz 0x101772ae */
            ii(0x1017_72a7, 5); mov(ebx, 0xd);                          /* mov ebx, 0xd */
            ii(0x1017_72ac, 2); jmpd(0x1017_72c9, 0x1b); goto l_0x1017_72c9; /* jmp 0x101772c9 */
        l_0x1017_72ae:
            ii(0x1017_72ae, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_72b1, 2); if(jnzd(0x1017_72ba, 0x7)) goto l_0x1017_72ba; /* jnz 0x101772ba */
            ii(0x1017_72b3, 5); mov(ebx, 0xd);                          /* mov ebx, 0xd */
            ii(0x1017_72b8, 2); jmpd(0x1017_72c9, 0xf); goto l_0x1017_72c9; /* jmp 0x101772c9 */
        l_0x1017_72ba:
            ii(0x1017_72ba, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_72bd, 2); if(jzd(0x1017_72c2, 0x3)) goto l_0x1017_72c2; /* jz 0x101772c2 */
            ii(0x1017_72bf, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_72c2:
            ii(0x1017_72c2, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
            ii(0x1017_72c7, 2); mov(ebx, eax);                          /* mov ebx, eax */
        l_0x1017_72c9:
            ii(0x1017_72c9, 7); lea(eax, ebx * 4 + 0);                  /* lea eax, [ebx*4] */
            ii(0x1017_72d0, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_72d2, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a42], 0x2b); /* mov word [eax*2+0x10208a42], 0x2b */
            ii(0x1017_72dc, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_72de, 2); if(jnzd(0x1017_72e7, 0x7)) goto l_0x1017_72e7; /* jnz 0x101772e7 */
            ii(0x1017_72e0, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1017_72e5, 2); jmpd(0x1017_7300, 0x19); goto l_0x1017_7300; /* jmp 0x10177300 */
        l_0x1017_72e7:
            ii(0x1017_72e7, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_72ea, 2); if(jnzd(0x1017_72f3, 0x7)) goto l_0x1017_72f3; /* jnz 0x101772f3 */
            ii(0x1017_72ec, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1017_72f1, 2); jmpd(0x1017_7300, 0xd); goto l_0x1017_7300; /* jmp 0x10177300 */
        l_0x1017_72f3:
            ii(0x1017_72f3, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_72f6, 2); if(jzd(0x1017_72fb, 0x3)) goto l_0x1017_72fb; /* jz 0x101772fb */
            ii(0x1017_72f8, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_72fb:
            ii(0x1017_72fb, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
        l_0x1017_7300:
            ii(0x1017_7300, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_7302, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_7305, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_7307, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a44], 0xffff); /* mov word [eax*2+0x10208a44], 0xffff */
            ii(0x1017_7311, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_7313, 2); if(jnzd(0x1017_731c, 0x7)) goto l_0x1017_731c; /* jnz 0x1017731c */
            ii(0x1017_7315, 5); mov(ebx, 0xd);                          /* mov ebx, 0xd */
            ii(0x1017_731a, 2); jmpd(0x1017_7337, 0x1b); goto l_0x1017_7337; /* jmp 0x10177337 */
        l_0x1017_731c:
            ii(0x1017_731c, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_731f, 2); if(jnzd(0x1017_7328, 0x7)) goto l_0x1017_7328; /* jnz 0x10177328 */
            ii(0x1017_7321, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1017_7326, 2); jmpd(0x1017_7335, 0xd); goto l_0x1017_7335; /* jmp 0x10177335 */
        l_0x1017_7328:
            ii(0x1017_7328, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_732b, 2); if(jzd(0x1017_7330, 0x3)) goto l_0x1017_7330; /* jz 0x10177330 */
            ii(0x1017_732d, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_7330:
            ii(0x1017_7330, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
        l_0x1017_7335:
            ii(0x1017_7335, 2); mov(ebx, eax);                          /* mov ebx, eax */
        l_0x1017_7337:
            ii(0x1017_7337, 7); lea(eax, ebx * 4 + 0);                  /* lea eax, [ebx*4] */
            ii(0x1017_733e, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_7340, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a46], 0x7d); /* mov word [eax*2+0x10208a46], 0x7d */
            ii(0x1017_734a, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_734c, 2); if(jnzd(0x1017_7355, 0x7)) goto l_0x1017_7355; /* jnz 0x10177355 */
            ii(0x1017_734e, 5); mov(ebx, 0xd);                          /* mov ebx, 0xd */
            ii(0x1017_7353, 2); jmpd(0x1017_7370, 0x1b); goto l_0x1017_7370; /* jmp 0x10177370 */
        l_0x1017_7355:
            ii(0x1017_7355, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_7358, 2); if(jnzd(0x1017_7361, 0x7)) goto l_0x1017_7361; /* jnz 0x10177361 */
            ii(0x1017_735a, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1017_735f, 2); jmpd(0x1017_736e, 0xd); goto l_0x1017_736e; /* jmp 0x1017736e */
        l_0x1017_7361:
            ii(0x1017_7361, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_7364, 2); if(jzd(0x1017_7369, 0x3)) goto l_0x1017_7369; /* jz 0x10177369 */
            ii(0x1017_7366, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_7369:
            ii(0x1017_7369, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
        l_0x1017_736e:
            ii(0x1017_736e, 2); mov(ebx, eax);                          /* mov ebx, eax */
        l_0x1017_7370:
            ii(0x1017_7370, 7); lea(eax, ebx * 4 + 0);                  /* lea eax, [ebx*4] */
            ii(0x1017_7377, 5); mov(ecx, 0x88);                         /* mov ecx, 0x88 */
            ii(0x1017_737c, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_737e, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1017_7383, 5); mov(esi, 0xa8);                         /* mov esi, 0xa8 */
            ii(0x1017_7388, 8); mov(memw_a32[ds, eax * 2 + 0x1020_8a48], bx); /* mov [eax*2+0x10208a48], bx */
            ii(0x1017_7390, 5); mov(eax, 0xa4);                         /* mov eax, 0xa4 */
            ii(0x1017_7395, 7); mov(memw_a32[ds, 0x1020_8b44], cx);     /* mov [0x10208b44], cx */
            ii(0x1017_739c, 7); mov(memw_a32[ds, 0x1020_8b46], si);     /* mov [0x10208b46], si */
            ii(0x1017_73a3, 7); mov(memw_a32[ds, 0x1020_8b48], bx);     /* mov [0x10208b48], bx */
            ii(0x1017_73aa, 7); mov(memw_a32[ds, 0x1020_8b4a], bx);     /* mov [0x10208b4a], bx */
            ii(0x1017_73b1, 7); mov(memw_a32[ds, 0x1020_8b4c], bx);     /* mov [0x10208b4c], bx */
            ii(0x1017_73b8, 7); mov(memw_a32[ds, 0x1020_8b52], bx);     /* mov [0x10208b52], bx */
            ii(0x1017_73bf, 7); mov(memw_a32[ds, 0x1020_8b56], bx);     /* mov [0x10208b56], bx */
            ii(0x1017_73c6, 7); mov(memw_a32[ds, 0x1020_8bd4], bx);     /* mov [0x10208bd4], bx */
            ii(0x1017_73cd, 7); mov(memw_a32[ds, 0x1020_8bd6], bx);     /* mov [0x10208bd6], bx */
            ii(0x1017_73d4, 7); mov(memw_a32[ds, 0x1020_8bd8], bx);     /* mov [0x10208bd8], bx */
            ii(0x1017_73db, 7); mov(memw_a32[ds, 0x1020_8bf2], bx);     /* mov [0x10208bf2], bx */
            ii(0x1017_73e2, 7); mov(memw_a32[ds, 0x1020_8bf4], bx);     /* mov [0x10208bf4], bx */
            ii(0x1017_73e9, 7); mov(memw_a32[ds, 0x1020_8bf6], bx);     /* mov [0x10208bf6], bx */
            ii(0x1017_73f0, 7); mov(memw_a32[ds, 0x1020_8da0], bx);     /* mov [0x10208da0], bx */
            ii(0x1017_73f7, 7); mov(memw_a32[ds, 0x1020_8da2], bx);     /* mov [0x10208da2], bx */
            ii(0x1017_73fe, 7); mov(memw_a32[ds, 0x1020_8da4], bx);     /* mov [0x10208da4], bx */
            ii(0x1017_7405, 5); mov(ecx, 0x24);                         /* mov ecx, 0x24 */
            ii(0x1017_740a, 5); mov(esi, 0xa3);                         /* mov esi, 0xa3 */
            ii(0x1017_740f, 6); mov(memw_a32[ds, 0x1020_8b54], ax);     /* mov [0x10208b54], ax */
            ii(0x1017_7415, 7); mov(memw_a32[ds, 0x1020_8b4e], cx);     /* mov [0x10208b4e], cx */
            ii(0x1017_741c, 7); mov(memw_a32[ds, 0x1020_8b50], si);     /* mov [0x10208b50], si */
            ii(0x1017_7423, 5); mov(ecx, 0xf9);                         /* mov ecx, 0xf9 */
            ii(0x1017_7428, 5); mov(esi, 0x25);                         /* mov esi, 0x25 */
            ii(0x1017_742d, 7); mov(memw_a32[ds, 0x1020_8bd0], cx);     /* mov [0x10208bd0], cx */
            ii(0x1017_7434, 7); mov(memw_a32[ds, 0x1020_8bd2], si);     /* mov [0x10208bd2], si */
            ii(0x1017_743b, 5); mov(ecx, 0x2a);                         /* mov ecx, 0x2a */
            ii(0x1017_7440, 5); mov(esi, 0xb5);                         /* mov esi, 0xb5 */
            ii(0x1017_7445, 7); mov(memw_a32[ds, 0x1020_8bee], cx);     /* mov [0x10208bee], cx */
            ii(0x1017_744c, 7); mov(memw_a32[ds, 0x1020_8bf0], si);     /* mov [0x10208bf0], si */
            ii(0x1017_7453, 5); mov(ecx, 0x3c);                         /* mov ecx, 0x3c */
            ii(0x1017_7458, 5); mov(esi, 0x3e);                         /* mov esi, 0x3e */
            ii(0x1017_745d, 7); mov(memw_a32[ds, 0x1020_8d9c], cx);     /* mov [0x10208d9c], cx */
            ii(0x1017_7464, 7); mov(memw_a32[ds, 0x1020_8d9e], si);     /* mov [0x10208d9e], si */
            ii(0x1017_746b, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_746d, 2); if(jzd(0x1017_7483, 0x14)) goto l_0x1017_7483; /* jz 0x10177483 */
            ii(0x1017_746f, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_7472, 2); if(jnzd(0x1017_747b, 0x7)) goto l_0x1017_747b; /* jnz 0x1017747b */
            ii(0x1017_7474, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
            ii(0x1017_7479, 2); jmpd(0x1017_7488, 0xd); goto l_0x1017_7488; /* jmp 0x10177488 */
        l_0x1017_747b:
            ii(0x1017_747b, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_747e, 2); if(jzd(0x1017_7483, 0x3)) goto l_0x1017_7483; /* jz 0x10177483 */
            ii(0x1017_7480, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_7483:
            ii(0x1017_7483, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
        l_0x1017_7488:
            ii(0x1017_7488, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_748a, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_748d, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_748f, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a40], 0x2c); /* mov word [eax*2+0x10208a40], 0x2c */
            ii(0x1017_7499, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_749b, 2); if(jzd(0x1017_74b1, 0x14)) goto l_0x1017_74b1; /* jz 0x101774b1 */
            ii(0x1017_749d, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_74a0, 2); if(jnzd(0x1017_74a9, 0x7)) goto l_0x1017_74a9; /* jnz 0x101774a9 */
            ii(0x1017_74a2, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
            ii(0x1017_74a7, 2); jmpd(0x1017_74b6, 0xd); goto l_0x1017_74b6; /* jmp 0x101774b6 */
        l_0x1017_74a9:
            ii(0x1017_74a9, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_74ac, 2); if(jzd(0x1017_74b1, 0x3)) goto l_0x1017_74b1; /* jz 0x101774b1 */
            ii(0x1017_74ae, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_74b1:
            ii(0x1017_74b1, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
        l_0x1017_74b6:
            ii(0x1017_74b6, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_74b8, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_74bb, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_74bd, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a42], 0x3f); /* mov word [eax*2+0x10208a42], 0x3f */
            ii(0x1017_74c7, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_74c9, 2); if(jnzd(0x1017_74d2, 0x7)) goto l_0x1017_74d2; /* jnz 0x101774d2 */
            ii(0x1017_74cb, 5); mov(ebx, 0x33);                         /* mov ebx, 0x33 */
            ii(0x1017_74d0, 2); jmpd(0x1017_74ed, 0x1b); goto l_0x1017_74ed; /* jmp 0x101774ed */
        l_0x1017_74d2:
            ii(0x1017_74d2, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_74d5, 2); if(jnzd(0x1017_74de, 0x7)) goto l_0x1017_74de; /* jnz 0x101774de */
            ii(0x1017_74d7, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
            ii(0x1017_74dc, 2); jmpd(0x1017_74eb, 0xd); goto l_0x1017_74eb; /* jmp 0x101774eb */
        l_0x1017_74de:
            ii(0x1017_74de, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_74e1, 2); if(jzd(0x1017_74e6, 0x3)) goto l_0x1017_74e6; /* jz 0x101774e6 */
            ii(0x1017_74e3, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_74e6:
            ii(0x1017_74e6, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
        l_0x1017_74eb:
            ii(0x1017_74eb, 2); mov(ebx, eax);                          /* mov ebx, eax */
        l_0x1017_74ed:
            ii(0x1017_74ed, 7); lea(eax, ebx * 4 + 0);                  /* lea eax, [ebx*4] */
            ii(0x1017_74f4, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_74f6, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a44], 0xffff); /* mov word [eax*2+0x10208a44], 0xffff */
            ii(0x1017_7500, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_7502, 2); if(jzd(0x1017_7518, 0x14)) goto l_0x1017_7518; /* jz 0x10177518 */
            ii(0x1017_7504, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_7507, 2); if(jnzd(0x1017_7510, 0x7)) goto l_0x1017_7510; /* jnz 0x10177510 */
            ii(0x1017_7509, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
            ii(0x1017_750e, 2); jmpd(0x1017_751d, 0xd); goto l_0x1017_751d; /* jmp 0x1017751d */
        l_0x1017_7510:
            ii(0x1017_7510, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_7513, 2); if(jzd(0x1017_7518, 0x3)) goto l_0x1017_7518; /* jz 0x10177518 */
            ii(0x1017_7515, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_7518:
            ii(0x1017_7518, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
        l_0x1017_751d:
            ii(0x1017_751d, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_751f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_7522, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_7524, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a46], 0xffff); /* mov word [eax*2+0x10208a46], 0xffff */
            ii(0x1017_752e, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_7530, 2); if(jzd(0x1017_7546, 0x14)) goto l_0x1017_7546; /* jz 0x10177546 */
            ii(0x1017_7532, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_7535, 2); if(jnzd(0x1017_753e, 0x7)) goto l_0x1017_753e; /* jnz 0x1017753e */
            ii(0x1017_7537, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
            ii(0x1017_753c, 2); jmpd(0x1017_754b, 0xd); goto l_0x1017_754b; /* jmp 0x1017754b */
        l_0x1017_753e:
            ii(0x1017_753e, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_7541, 2); if(jzd(0x1017_7546, 0x3)) goto l_0x1017_7546; /* jz 0x10177546 */
            ii(0x1017_7543, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_7546:
            ii(0x1017_7546, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
        l_0x1017_754b:
            ii(0x1017_754b, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_754d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_7550, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_7552, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a48], 0xffff); /* mov word [eax*2+0x10208a48], 0xffff */
            ii(0x1017_755c, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_755e, 2); if(jnzd(0x1017_7567, 0x7)) goto l_0x1017_7567; /* jnz 0x10177567 */
            ii(0x1017_7560, 5); mov(eax, 0x27);                         /* mov eax, 0x27 */
            ii(0x1017_7565, 2); jmpd(0x1017_7579, 0x12); goto l_0x1017_7579; /* jmp 0x10177579 */
        l_0x1017_7567:
            ii(0x1017_7567, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_756a, 2); if(jzd(0x1017_7574, 0x8)) goto l_0x1017_7574; /* jz 0x10177574 */
            ii(0x1017_756c, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_756f, 2); if(jzd(0x1017_7574, 0x3)) goto l_0x1017_7574; /* jz 0x10177574 */
            ii(0x1017_7571, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_7574:
            ii(0x1017_7574, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
        l_0x1017_7579:
            ii(0x1017_7579, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_757b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_757e, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_7580, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a40], 0x3b); /* mov word [eax*2+0x10208a40], 0x3b */
            ii(0x1017_758a, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_758c, 2); if(jnzd(0x1017_7595, 0x7)) goto l_0x1017_7595; /* jnz 0x10177595 */
            ii(0x1017_758e, 5); mov(eax, 0x27);                         /* mov eax, 0x27 */
            ii(0x1017_7593, 2); jmpd(0x1017_75a7, 0x12); goto l_0x1017_75a7; /* jmp 0x101775a7 */
        l_0x1017_7595:
            ii(0x1017_7595, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_7598, 2); if(jzd(0x1017_75a2, 0x8)) goto l_0x1017_75a2; /* jz 0x101775a2 */
            ii(0x1017_759a, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_759d, 2); if(jzd(0x1017_75a2, 0x3)) goto l_0x1017_75a2; /* jz 0x101775a2 */
            ii(0x1017_759f, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_75a2:
            ii(0x1017_75a2, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
        l_0x1017_75a7:
            ii(0x1017_75a7, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_75a9, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_75ac, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_75ae, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a42], 0x2e); /* mov word [eax*2+0x10208a42], 0x2e */
            ii(0x1017_75b8, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_75ba, 2); if(jnzd(0x1017_75c3, 0x7)) goto l_0x1017_75c3; /* jnz 0x101775c3 */
            ii(0x1017_75bc, 5); mov(eax, 0x27);                         /* mov eax, 0x27 */
            ii(0x1017_75c1, 2); jmpd(0x1017_75d5, 0x12); goto l_0x1017_75d5; /* jmp 0x101775d5 */
        l_0x1017_75c3:
            ii(0x1017_75c3, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_75c6, 2); if(jzd(0x1017_75d0, 0x8)) goto l_0x1017_75d0; /* jz 0x101775d0 */
            ii(0x1017_75c8, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_75cb, 2); if(jzd(0x1017_75d0, 0x3)) goto l_0x1017_75d0; /* jz 0x101775d0 */
            ii(0x1017_75cd, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_75d0:
            ii(0x1017_75d0, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
        l_0x1017_75d5:
            ii(0x1017_75d5, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_75d7, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_75da, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_75dc, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a44], 0xffff); /* mov word [eax*2+0x10208a44], 0xffff */
            ii(0x1017_75e6, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_75e8, 2); if(jnzd(0x1017_75f1, 0x7)) goto l_0x1017_75f1; /* jnz 0x101775f1 */
            ii(0x1017_75ea, 5); mov(eax, 0x27);                         /* mov eax, 0x27 */
            ii(0x1017_75ef, 2); jmpd(0x1017_7603, 0x12); goto l_0x1017_7603; /* jmp 0x10177603 */
        l_0x1017_75f1:
            ii(0x1017_75f1, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_75f4, 2); if(jzd(0x1017_75fe, 0x8)) goto l_0x1017_75fe; /* jz 0x101775fe */
            ii(0x1017_75f6, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_75f9, 2); if(jzd(0x1017_75fe, 0x3)) goto l_0x1017_75fe; /* jz 0x101775fe */
            ii(0x1017_75fb, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_75fe:
            ii(0x1017_75fe, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
        l_0x1017_7603:
            ii(0x1017_7603, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_7605, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_7608, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_760a, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a46], 0xffff); /* mov word [eax*2+0x10208a46], 0xffff */
            ii(0x1017_7614, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_7616, 2); if(jnzd(0x1017_761f, 0x7)) goto l_0x1017_761f; /* jnz 0x1017761f */
            ii(0x1017_7618, 5); mov(eax, 0x27);                         /* mov eax, 0x27 */
            ii(0x1017_761d, 2); jmpd(0x1017_7631, 0x12); goto l_0x1017_7631; /* jmp 0x10177631 */
        l_0x1017_761f:
            ii(0x1017_761f, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_7622, 2); if(jzd(0x1017_762c, 0x8)) goto l_0x1017_762c; /* jz 0x1017762c */
            ii(0x1017_7624, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_7627, 2); if(jzd(0x1017_762c, 0x3)) goto l_0x1017_762c; /* jz 0x1017762c */
            ii(0x1017_7629, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_762c:
            ii(0x1017_762c, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
        l_0x1017_7631:
            ii(0x1017_7631, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_7633, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_7636, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_7638, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a48], 0xffff); /* mov word [eax*2+0x10208a48], 0xffff */
            ii(0x1017_7642, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_7644, 2); if(jnzd(0x1017_764d, 0x7)) goto l_0x1017_764d; /* jnz 0x1017764d */
            ii(0x1017_7646, 5); mov(eax, 0x27);                         /* mov eax, 0x27 */
            ii(0x1017_764b, 2); jmpd(0x1017_765f, 0x12); goto l_0x1017_765f; /* jmp 0x1017765f */
        l_0x1017_764d:
            ii(0x1017_764d, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_7650, 2); if(jzd(0x1017_765a, 0x8)) goto l_0x1017_765a; /* jz 0x1017765a */
            ii(0x1017_7652, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_7655, 2); if(jzd(0x1017_765a, 0x3)) goto l_0x1017_765a; /* jz 0x1017765a */
            ii(0x1017_7657, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_765a:
            ii(0x1017_765a, 5); mov(eax, 0x34);                         /* mov eax, 0x34 */
        l_0x1017_765f:
            ii(0x1017_765f, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_7661, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_7664, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_7666, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a40], 0x3a); /* mov word [eax*2+0x10208a40], 0x3a */
            ii(0x1017_7670, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_7672, 2); if(jnzd(0x1017_767b, 0x7)) goto l_0x1017_767b; /* jnz 0x1017767b */
            ii(0x1017_7674, 5); mov(eax, 0x27);                         /* mov eax, 0x27 */
            ii(0x1017_7679, 2); jmpd(0x1017_768d, 0x12); goto l_0x1017_768d; /* jmp 0x1017768d */
        l_0x1017_767b:
            ii(0x1017_767b, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_767e, 2); if(jzd(0x1017_7688, 0x8)) goto l_0x1017_7688; /* jz 0x10177688 */
            ii(0x1017_7680, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_7683, 2); if(jzd(0x1017_7688, 0x3)) goto l_0x1017_7688; /* jz 0x10177688 */
            ii(0x1017_7685, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_7688:
            ii(0x1017_7688, 5); mov(eax, 0x34);                         /* mov eax, 0x34 */
        l_0x1017_768d:
            ii(0x1017_768d, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_768f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_7692, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_7694, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a42], 0x2f); /* mov word [eax*2+0x10208a42], 0x2f */
            ii(0x1017_769e, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_76a0, 2); if(jnzd(0x1017_76a9, 0x7)) goto l_0x1017_76a9; /* jnz 0x101776a9 */
            ii(0x1017_76a2, 5); mov(eax, 0x27);                         /* mov eax, 0x27 */
            ii(0x1017_76a7, 2); jmpd(0x1017_76bb, 0x12); goto l_0x1017_76bb; /* jmp 0x101776bb */
        l_0x1017_76a9:
            ii(0x1017_76a9, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_76ac, 2); if(jzd(0x1017_76b6, 0x8)) goto l_0x1017_76b6; /* jz 0x101776b6 */
            ii(0x1017_76ae, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_76b1, 2); if(jzd(0x1017_76b6, 0x3)) goto l_0x1017_76b6; /* jz 0x101776b6 */
            ii(0x1017_76b3, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_76b6:
            ii(0x1017_76b6, 5); mov(eax, 0x34);                         /* mov eax, 0x34 */
        l_0x1017_76bb:
            ii(0x1017_76bb, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_76bd, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_76c0, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_76c2, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a44], 0xffff); /* mov word [eax*2+0x10208a44], 0xffff */
            ii(0x1017_76cc, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_76ce, 2); if(jnzd(0x1017_76d7, 0x7)) goto l_0x1017_76d7; /* jnz 0x101776d7 */
            ii(0x1017_76d0, 5); mov(eax, 0x27);                         /* mov eax, 0x27 */
            ii(0x1017_76d5, 2); jmpd(0x1017_76e9, 0x12); goto l_0x1017_76e9; /* jmp 0x101776e9 */
        l_0x1017_76d7:
            ii(0x1017_76d7, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_76da, 2); if(jzd(0x1017_76e4, 0x8)) goto l_0x1017_76e4; /* jz 0x101776e4 */
            ii(0x1017_76dc, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_76df, 2); if(jzd(0x1017_76e4, 0x3)) goto l_0x1017_76e4; /* jz 0x101776e4 */
            ii(0x1017_76e1, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_76e4:
            ii(0x1017_76e4, 5); mov(eax, 0x34);                         /* mov eax, 0x34 */
        l_0x1017_76e9:
            ii(0x1017_76e9, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_76eb, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_76ee, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_76f0, 10); mov(memw_a32[ds, eax * 2 + 0x1020_8a46], 0xffff); /* mov word [eax*2+0x10208a46], 0xffff */
            ii(0x1017_76fa, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_76fc, 2); if(jnzd(0x1017_7705, 0x7)) goto l_0x1017_7705; /* jnz 0x10177705 */
            ii(0x1017_76fe, 5); mov(ebx, 0x27);                         /* mov ebx, 0x27 */
            ii(0x1017_7703, 2); jmpd(0x1017_7720, 0x1b); goto l_0x1017_7720; /* jmp 0x10177720 */
        l_0x1017_7705:
            ii(0x1017_7705, 3); cmp(edx, 0x1);                          /* cmp edx, 0x1 */
            ii(0x1017_7708, 2); if(jnzd(0x1017_7711, 0x7)) goto l_0x1017_7711; /* jnz 0x10177711 */
            ii(0x1017_770a, 5); mov(ebx, 0x34);                         /* mov ebx, 0x34 */
            ii(0x1017_770f, 2); jmpd(0x1017_7720, 0xf); goto l_0x1017_7720; /* jmp 0x10177720 */
        l_0x1017_7711:
            ii(0x1017_7711, 3); cmp(edx, 0x4);                          /* cmp edx, 0x4 */
            ii(0x1017_7714, 2); if(jzd(0x1017_7719, 0x3)) goto l_0x1017_7719; /* jz 0x10177719 */
            ii(0x1017_7716, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
        l_0x1017_7719:
            ii(0x1017_7719, 5); mov(eax, 0x34);                         /* mov eax, 0x34 */
            ii(0x1017_771e, 2); mov(ebx, eax);                          /* mov ebx, eax */
        l_0x1017_7720:
            ii(0x1017_7720, 7); lea(eax, ebx * 4 + 0);                  /* lea eax, [ebx*4] */
            ii(0x1017_7727, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_7729, 5); mov(edi, 0xffff_ffff);                  /* mov edi, 0xffffffff */
            ii(0x1017_772e, 5); mov(ebx, 0xa7);                         /* mov ebx, 0xa7 */
            ii(0x1017_7733, 8); mov(memw_a32[ds, eax * 2 + 0x1020_8a48], di); /* mov [eax*2+0x10208a48], di */
            ii(0x1017_773b, 5); mov(eax, 0x21);                         /* mov eax, 0x21 */
            ii(0x1017_7740, 7); mov(memw_a32[ds, 0x1020_8c54], bx);     /* mov [0x10208c54], bx */
            ii(0x1017_7747, 7); mov(memw_a32[ds, 0x1020_8c56], di);     /* mov [0x10208c56], di */
            ii(0x1017_774e, 7); mov(memw_a32[ds, 0x1020_8c58], di);     /* mov [0x10208c58], di */
            ii(0x1017_7755, 7); mov(memw_a32[ds, 0x1020_8c5a], di);     /* mov [0x10208c5a], di */
            ii(0x1017_775c, 6); mov(memw_a32[ds, 0x1020_8c52], ax);     /* mov [0x10208c52], ax */
            ii(0x1017_7762, 6); mov(memd_a32[ds, 0x1020_9540], edx);    /* mov [0x10209540], edx */
            ii(0x1017_7768, 1); popd(edi);                              /* pop edi */
            ii(0x1017_7769, 1); popd(esi);                              /* pop esi */
            ii(0x1017_776a, 1); popd(edx);                              /* pop edx */
            ii(0x1017_776b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_776c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_776d, 1); retd();                                 /* ret */
        }
    }
}
